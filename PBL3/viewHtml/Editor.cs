using mshtml;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;

namespace PBL3.viewHtml
{
    public partial class Editor : UserControl, SearchableBrowser
    {
        private IHTMLDocument2 doc;
        private bool updatingFontName = false;
        private bool updatingFontSize = false;
        private bool setup = false;
        private bool init_timer = false;
        public delegate void TickDelegate();

        public class EnterKeyEventArgs : EventArgs
        {
            private bool _cancel = false;
            public bool Cancel
            {
                get { return _cancel; }
                set { _cancel = value; }
            }

        }
        public event TickDelegate Tick;
        public event WebBrowserNavigatedEventHandler Navigated;
        public event EventHandler<EnterKeyEventArgs> EnterKeyEvent;
        public Editor()
        {
#if TRIAL
            var form = new SplashForm();
            form.ShowDialog();
#endif
            Load += new EventHandler(Editor_Load);
            InitializeComponent();
            SetupEvents();
            SetupTimer();
            SetupBrowser();
            SetupFontComboBox();
            SetupFontSizeComboBox();
            boldButton.CheckedChanged += delegate
            {
                if (BoldChanged != null)
                    BoldChanged();
            };
            italicButton.CheckedChanged += delegate
            {
                if (ItalicChanged != null)
                    ItalicChanged();
            };
            underlineButton.CheckedChanged += delegate
            {
                if (UnderlineChanged != null)
                    UnderlineChanged();
            };
            orderedListButton.CheckedChanged += delegate
            {
                if (OrderedListChanged != null)
                    OrderedListChanged();
            };
            unorderedListButton.CheckedChanged += delegate
            {
                if (UnorderedListChanged != null)
                    UnorderedListChanged();
            };
            justifyLeftButton.CheckedChanged += delegate
            {
                if (JustifyLeftChanged != null)
                    JustifyLeftChanged();
            };
            justifyCenterButton.CheckedChanged += delegate
            {
                if (JustifyCenterChanged != null)
                    JustifyCenterChanged();
            };
            justifyRightButton.CheckedChanged += delegate
            {
                if (JustifyRightChanged != null)
                    JustifyRightChanged();
            };
            justifyFullButton.CheckedChanged += delegate
            {
                if (JustifyFullChanged != null)
                    JustifyFullChanged();
            };
        }
        private void Editor_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
        private void ParentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
            ParentForm.FormClosed -= new FormClosedEventHandler(ParentForm_FormClosed);
        }
        private void SetupEvents()
        {
            webBrowser1.Navigated += new WebBrowserNavigatedEventHandler(webBrowser1_Navigated);
            webBrowser1.GotFocus += new EventHandler(webBrowser1_GotFocus);
            if (webBrowser1.Version.Major >= 9)
                webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.Document.Body != null)
                webBrowser1.Document.Body.SetAttribute("contentEditable", "true");
        }
        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        private void webBrowser1_GotFocus(object sender, EventArgs e)
        {
            SuperFocus();
        }
        /// <param name="sender">sender</param>
        /// <param name="e">navigation args</param>
        void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            SetBackgroundColor(BackColor);
            if (Navigated != null)
            {
                Navigated(this, e);
            }
        }
        private void SetupTimer()
        {
            timer.Interval = 200;
            timer.Tick += new EventHandler(timer_Tick);
        }
        private void SetupBrowser()
        {
            webBrowser1.DocumentText = "<html><body></body></html>";
            doc =
                webBrowser1.Document.DomDocument as IHTMLDocument2;
            doc.designMode = "On";
            webBrowser1.Document.ContextMenuShowing +=
                new HtmlElementEventHandler(Document_ContextMenuShowing);
        }
        private void SuperFocus()
        {
            if (webBrowser1.Document != null &&
                webBrowser1.Document.Body != null)
                webBrowser1.Document.Body.Focus();
        }

        [Browsable(true)]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                if (ReadyState == ReadyState.Complete)
                {
                    SetBackgroundColor(value);
                }
            }
        }
        /// <param name="value">the color to use for the background</param>
        private void SetBackgroundColor(Color value)
        {
            if (webBrowser1.Document != null &&
                webBrowser1.Document.Body != null)
                webBrowser1.Document.Body.Style =
                    string.Format("background-color: {0}", value.Name);
        }
        public void Clear()
        {
            if (webBrowser1.Document.Body != null)
                webBrowser1.Document.Body.InnerHtml = "";
        }
        public HtmlDocument Document
        {
            get { return webBrowser1.Document; }
        }
        [Browsable(false)]
        public string DocumentText
        {
            get
            {
                string html = webBrowser1.DocumentText;
                if (html != null)
                {
                    html = ReplaceFileSystemImages(html);
                }
                return html;
            }
            set
            {
                if (value == null)
                    webBrowser1.Document.Write("<html><body></body></html>");
                else
                {
                    webBrowser1.Document.Write(value);
                    fontComboBox.SelectedIndex = 317;
                    fontSizeComboBox.SelectedIndex = 3;
                }
            }
        }
        [Browsable(false)]
        public string DocumentTitle
        {
            get
            {
                return webBrowser1.DocumentTitle;
            }
        }
        [Browsable(false)]
        public string BodyHtml
        {
            get
            {
                if (webBrowser1.Document != null &&
                    webBrowser1.Document.Body != null)
                {
                    string html = webBrowser1.Document.Body.InnerHtml;
                    if (html != null)
                    {
                        html = ReplaceFileSystemImages(html);
                    }
                    return html;
                }
                else
                    return string.Empty;
            }
            set
            {
                if (webBrowser1.Document.Body != null)
                    webBrowser1.Document.Body.InnerHtml = value;
            }
        }
        private string ReplaceFileSystemImages(string html)
        {
            var matches = Regex.Matches(html, @"<img[^>]*?src\s*=\s*([""']?[^'"">]+?['""])[^>]*?>", RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline);
            foreach (Match match in matches)
            {
                string src = match.Groups[1].Value;
                src = src.Trim('\"');
                if (File.Exists(src))
                {
                    var ext = Path.GetExtension(src);
                    if (ext.Length > 0)
                    {
                        ext = ext.Substring(1);
                        src = string.Format("'data:image/{0};base64,{1}'", ext, Convert.ToBase64String(File.ReadAllBytes(src)));
                        html = html.Replace(match.Groups[1].Value, src);
                    }
                }
            }
            return html;
        }
        [Browsable(false)]
        public string BodyText
        {
            get
            {
                if (webBrowser1.Document != null &&
                    webBrowser1.Document.Body != null)
                {
                    return webBrowser1.Document.Body.InnerText;
                }
                else
                    return string.Empty;
            }
            set
            {
                Document.OpenNew(false);
                if (webBrowser1.Document.Body != null)
                    webBrowser1.Document.Body.InnerText = HttpUtility.HtmlEncode(value);
            }
        }
        [Browsable(false)]
        public string Html
        {
            get
            {
                if (webBrowser1.Document != null &&
                    webBrowser1.Document.Body != null)
                {
                    return webBrowser1.Document.Body.InnerHtml;
                }
                else
                    return string.Empty;
            }
            set
            {
                Document.OpenNew(false);
                IHTMLDocument2 dom = Document.DomDocument as IHTMLDocument2;
                try
                {
                    if (value == null)
                        dom.clear();
                    else
                        dom.write(value);
                }
                finally
                {
                    dom.close();
                }
            }
        }
        public bool CanUndo()
        {
            return doc.queryCommandEnabled("Undo");
        }
        public bool CanRedo()
        {
            return doc.queryCommandEnabled("Redo");
        }
        public bool CanCut()
        {
            return doc.queryCommandEnabled("Cut");
        }
        public bool CanCopy()
        {
            return doc.queryCommandEnabled("Copy");
        }
        public bool CanPaste()
        {
            return doc.queryCommandEnabled("Paste");
        }
        public bool CanDelete()
        {
            return doc.queryCommandEnabled("Delete");
        }
        public bool IsJustifyLeft()
        {
            return doc.queryCommandState("JustifyLeft");
        }
        public bool IsJustifyRight()
        {
            return doc.queryCommandState("JustifyRight");
        }
        public bool IsJustifyCenter()
        {
            return doc.queryCommandState("JustifyCenter");
        }
        public bool IsJustifyFull()
        {
            return doc.queryCommandState("JustifyFull");
        }
        public bool IsBold()
        {
            return doc.queryCommandState("Bold");
        }
        public bool IsItalic()
        {
            return doc.queryCommandState("Italic");
        }
        public bool IsUnderline()
        {
            return doc.queryCommandState("Underline");
        }
        public bool IsOrderedList()
        {
            return doc.queryCommandState("InsertOrderedList");
        }
        public bool IsUnorderedList()
        {
            return doc.queryCommandState("InsertUnorderedList");
        }
        /// <param name="sender">the sender</param>
        /// <param name="e">HtmlElementEventArgs</param>
        private void Document_ContextMenuShowing(object sender, HtmlElementEventArgs e)
        {
            e.ReturnValue = false;
            cutToolStripMenuItem1.Enabled = CanCut();
            copyToolStripMenuItem2.Enabled = CanCopy();
            pasteToolStripMenuItem3.Enabled = CanPaste();
            deleteToolStripMenuItem.Enabled = CanDelete();
            cSSToolStripMenuItem.Enabled = SelectionType != viewHtml.SelectionType.None;
            contextMenuStrip1.Show(this, e.ClientMousePosition);
        }
        private void SetupFontSizeComboBox()
        {
            for (int x = 1; x <= 7; x++) fontSizeComboBox.Items.Add(x.ToString());
            fontSizeComboBox.TextChanged += new EventHandler(fontSizeComboBox_TextChanged);
            fontSizeComboBox.KeyPress += new KeyPressEventHandler(fontSizeComboBox_KeyPress);
        }
        /// <param name="sender">the sender</param>
        /// <param name="e">KeyPressEventArgs</param>
        private void fontSizeComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                if (e.KeyChar <= '7' && e.KeyChar > '0') fontSizeComboBox.Text = e.KeyChar.ToString();
            }
            else if (!Char.IsControl(e.KeyChar)) e.Handled = true;
        }

        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        private void fontSizeComboBox_TextChanged(object sender, EventArgs e)
        {
            if (updatingFontSize) return;
            switch (fontSizeComboBox.Text.Trim())
            {
                case "1":
                    FontSize = FontSize.One;
                    break;
                case "2":
                    FontSize = FontSize.Two;
                    break;
                case "3":
                    FontSize = FontSize.Three;
                    break;
                case "4":
                    FontSize = FontSize.Four;
                    break;
                case "5":
                    FontSize = FontSize.Five;
                    break;
                case "6":
                    FontSize = FontSize.Six;
                    break;
                case "7":
                    FontSize = FontSize.Seven;
                    break;
                default:
                    FontSize = FontSize.Seven;
                    break;
            }
        }
        private void SetupFontComboBox()
        {
            AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            foreach (FontFamily fam in FontFamily.Families)
            {
                fontComboBox.Items.Add(fam.Name);
                ac.Add(fam.Name);
            }
            fontComboBox.Leave += new EventHandler(fontComboBox_TextChanged);
            fontComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            fontComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            fontComboBox.AutoCompleteCustomSource = ac;
        }
        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        private void fontComboBox_TextChanged(object sender, EventArgs e)
        {
            if (updatingFontName) return;
            FontFamily ff;
            try
            {
                ff = new FontFamily(fontComboBox.Text);
            }
            catch (Exception)
            {
                updatingFontName = true;
                fontComboBox.Text = FontName.GetName(0);
                updatingFontName = false;
                return;
            }
            FontName = ff;
        }
        private void UpdateImageSizes()
        {
            foreach (HTMLImg image in doc.images)
            {
                if (image != null)
                {
                    if (image.height != image.style.pixelHeight && image.style.pixelHeight != 0)
                        image.height = image.style.pixelHeight;
                    if (image.width != image.style.pixelWidth && image.style.pixelWidth != 0)
                        image.width = image.style.pixelWidth;
                }
            }
        }
        public event MethodInvoker BoldChanged;
        public event MethodInvoker ItalicChanged;
        public event MethodInvoker UnderlineChanged;
        public event MethodInvoker OrderedListChanged;
        public event MethodInvoker UnorderedListChanged;
        public event MethodInvoker JustifyLeftChanged;
        public event MethodInvoker JustifyCenterChanged;
        public event MethodInvoker JustifyRightChanged;
        public event MethodInvoker JustifyFullChanged;
        public event MethodInvoker HtmlFontChanged;
        public event MethodInvoker HtmlFontSizeChanged;
        private DateTime lastSplash = DateTime.Now;

        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        private void timer_Tick(object sender, EventArgs e)
        {
            if (!init_timer)
            {
                ParentForm.FormClosed += new FormClosedEventHandler(ParentForm_FormClosed);
                init_timer = true;
                lastSplash = DateTime.Now;
            }

            if (ReadyState != ReadyState.Complete) return;

#if TRIAL
            if (DateTime.Now.Subtract(lastSplash).TotalMinutes > 10)
            {
                lastSplash = DateTime.Now;
                var dlg = new SplashForm();
                dlg.ShowDialog();
            }
#endif
            SetupKeyListener();
            boldButton.Checked = IsBold();
            italicButton.Checked = IsItalic();
            underlineButton.Checked = IsUnderline();
            orderedListButton.Checked = IsOrderedList();
            unorderedListButton.Checked = IsUnorderedList();
            justifyLeftButton.Checked = IsJustifyLeft();
            justifyCenterButton.Checked = IsJustifyCenter();
            justifyRightButton.Checked = IsJustifyRight();
            justifyFullButton.Checked = IsJustifyFull();


            UpdateFontComboBox();
            UpdateFontSizeComboBox();
            UpdateImageSizes();

            if (Tick != null)
                Tick();
        }

        private void UpdateFontSizeComboBox()
        {
            if (!fontSizeComboBox.Focused)
            {
                int foo;
                switch (FontSize)
                {
                    case FontSize.One:
                        foo = 1;
                        break;
                    case FontSize.Two:
                        foo = 2;
                        break;
                    case FontSize.Three:
                        foo = 3;
                        break;
                    case FontSize.Four:
                        foo = 4;
                        break;
                    case FontSize.Five:
                        foo = 5;
                        break;
                    case FontSize.Six:
                        foo = 6;
                        break;
                    case FontSize.Seven:
                        foo = 7;
                        break;
                    case FontSize.NA:
                        foo = 0;
                        break;
                    default:
                        foo = 7;
                        break;
                }
                string fontsize = Convert.ToString(foo);
                if (fontsize != fontSizeComboBox.Text)
                {
                    updatingFontSize = true;
                    fontSizeComboBox.Text = fontsize;
                    if (HtmlFontSizeChanged != null)
                        HtmlFontSizeChanged();
                    updatingFontSize = false;
                }
            }
        }
        private void UpdateFontComboBox()
        {
            if (!fontComboBox.Focused)
            {
                FontFamily fam = FontName;
                if (fam != null)
                {
                    string fontname = fam.Name;
                    if (fontname != fontComboBox.Text)
                    {
                        updatingFontName = true;
                        fontComboBox.Text = fontname;
                        if (HtmlFontChanged != null) HtmlFontChanged();
                        updatingFontName = false;
                    }
                }
            }
        }
        public Color BodyBackgroundColor
        {
            get
            {
                if (doc.body != null && doc.body.style != null && doc.body.style.backgroundColor != null)
                    return ConvertToColor(doc.body.style.backgroundColor.ToString());
                return Color.White;
            }
            set
            {
                if (ReadyState == ReadyState.Complete)
                    if (doc.body != null && doc.body.style != null)
                    {
                        string colorstr = string.Format("#{0:X2}{1:X2}{2:X2}", value.R, value.G, value.B);
                        doc.body.style.backgroundColor = colorstr;
                    }
            }
        }

        private void SetupKeyListener()
        {
            if (!setup)
            {
                webBrowser1.Document.Body.KeyDown += new HtmlElementEventHandler(Body_KeyDown);
                setup = true;
            }
        }

        /// <param name="sender">the sender</param>
        /// <param name="e">HtmlElementEventArgs</param>
        private void Body_KeyDown(object sender, HtmlElementEventArgs e)
        {
            if (e.KeyPressedCode == 13 && !e.ShiftKeyPressed)
            {
                // handle enter code cancellation
                bool cancel = false;
                if (EnterKeyEvent != null)
                {
                    EnterKeyEventArgs args = new EnterKeyEventArgs();
                    EnterKeyEvent(this, args);
                    cancel = args.Cancel;
                }
                e.ReturnValue = !cancel;
            }
        }
        public void EmbedBr()
        {
            IHTMLTxtRange range =
                doc.selection.createRange() as IHTMLTxtRange;
            range.pasteHTML("<br/>");
            range.collapse(false);
            range.select();
        }
        private void SuperPaste()
        {
            if (Clipboard.ContainsText())
            {
                IHTMLTxtRange range =
                    doc.selection.createRange() as IHTMLTxtRange;
                range.pasteHTML(Clipboard.GetText(TextDataFormat.Text));
                range.collapse(false);
                range.select();
            }
        }
        public void Print()
        {
            webBrowser1.Document.ExecCommand("Print", true, null);
        }
        public void InsertParagraph()
        {
            webBrowser1.Document.ExecCommand("InsertParagraph", false, null);
        }
        public void InsertBreak()
        {
            webBrowser1.Document.ExecCommand("InsertHorizontalRule", false, null);
        }
        public void SelectAll()
        {
            webBrowser1.Document.ExecCommand("SelectAll", false, null);
        }
        public void Undo()
        {
            webBrowser1.Document.ExecCommand("Undo", false, null);
        }
        public void Redo()
        {
            webBrowser1.Document.ExecCommand("Redo", false, null);
        }
        public void Cut()
        {
            webBrowser1.Document.ExecCommand("Cut", false, null);
        }
        public void Paste()
        {
            webBrowser1.Document.ExecCommand("Paste", false, null);
        }
        public void Copy()
        {
            webBrowser1.Document.ExecCommand("Copy", false, null);
        }
        public void OrderedList()
        {
            webBrowser1.Document.ExecCommand("InsertOrderedList", false, null);
        }
        public void UnorderedList()
        {
            webBrowser1.Document.ExecCommand("InsertUnorderedList", false, null);
        }
        public void JustifyLeft()
        {
            webBrowser1.Document.ExecCommand("JustifyLeft", false, null);
        }
        public void JustifyRight()
        {
            webBrowser1.Document.ExecCommand("JustifyRight", false, null);
        }
        public void JustifyCenter()
        {
            webBrowser1.Document.ExecCommand("JustifyCenter", false, null);
        }
        public void JustifyFull()
        {
            webBrowser1.Document.ExecCommand("JustifyFull", false, null);
        }
        public void Bold()
        {
            webBrowser1.Document.ExecCommand("Bold", false, null);
        }
        public void Italic()
        {
            webBrowser1.Document.ExecCommand("Italic", false, null);
        }
        public void Underline()
        {
            webBrowser1.Document.ExecCommand("Underline", false, null);
        }
        public void Delete()
        {
            webBrowser1.Document.ExecCommand("Delete", false, null);
        }
        public void InsertImage()
        {
            webBrowser1.Document.ExecCommand("InsertImage", true, null);
        }
        public void Indent()
        {
            webBrowser1.Document.ExecCommand("Indent", false, null);
        }
        public void Outdent()
        {
            webBrowser1.Document.ExecCommand("Outdent", false, null);
        }
        /// <param name="url">The link url</param>
        public void InsertLink(string url)
        {
            webBrowser1.Document.ExecCommand("CreateLink", false, url);
        }
        public ReadyState ReadyState
        {
            get
            {
                switch (doc.readyState.ToLower())
                {
                    case "uninitialized":
                        return ReadyState.Uninitialized;
                    case "loading":
                        return ReadyState.Loading;
                    case "loaded":
                        return ReadyState.Loaded;
                    case "interactive":
                        return ReadyState.Interactive;
                    case "complete":
                        return ReadyState.Complete;
                    default:
                        return ReadyState.Uninitialized;
                }
            }
        }
        public SelectionType SelectionType
        {
            get
            {
                var type = doc.selection.type.ToLower();
                switch (type)
                {
                    case "text":
                        return SelectionType.Text;
                    case "control":
                        return SelectionType.Control;
                    case "none":
                        return SelectionType.None;
                    default:
                        return SelectionType.None;
                }
            }
        }
        [Browsable(false)]
        public FontSize FontSize
        {
            get
            {
                if (ReadyState != ReadyState.Complete) return FontSize.NA;
                string fs = doc.queryCommandValue("FontSize").ToString();
                switch (fs)
                {
                    case "1": return FontSize.One;
                    case "2": return FontSize.Two;
                    case "3": return FontSize.Three;
                    case "4": return FontSize.Four;
                    case "5": return FontSize.Five;
                    case "6": return FontSize.Six;
                    case "7": return FontSize.Seven;
                    default: return FontSize.NA;
                }
            }
            set
            {
                int sz;
                switch (value)
                {
                    case FontSize.One:
                        sz = 1;
                        break;
                    case FontSize.Two:
                        sz = 2;
                        break;
                    case FontSize.Three:
                        sz = 3;
                        break;
                    case FontSize.Four:
                        sz = 4;
                        break;
                    case FontSize.Five:
                        sz = 5;
                        break;
                    case FontSize.Six:
                        sz = 6;
                        break;
                    case FontSize.Seven:
                        sz = 7;
                        break;
                    default:
                        sz = 7;
                        break;
                }
                webBrowser1.Document.ExecCommand("FontSize", false, sz.ToString());
            }
        }

        [Browsable(false)]
        public FontFamily FontName
        {
            get
            {
                if (ReadyState != ReadyState.Complete) return null;
                string name = doc.queryCommandValue("FontName") as string;
                if (name == null) return null;
                return new FontFamily(name);
            }
            set
            {
                if (value != null) webBrowser1.Document.ExecCommand("FontName", false, value.Name);
            }
        }
        [Browsable(false)]
        public Color EditorForeColor
        {
            get
            {
                if (ReadyState != ReadyState.Complete)
                    return Color.Black;
                return ConvertToColor(doc.queryCommandValue("ForeColor").ToString());
            }
            set
            {
                string colorstr =
                    string.Format("#{0:X2}{1:X2}{2:X2}", value.R, value.G, value.B);
                webBrowser1.Document.ExecCommand("ForeColor", false, colorstr);
            }
        }
        [Browsable(false)]
        public Color EditorBackColor
        {
            get
            {
                if (ReadyState != ReadyState.Complete)
                    return Color.White;
                return ConvertToColor(doc.queryCommandValue("BackColor").ToString());
            }
            set
            {
                string colorstr =
                    string.Format("#{0:X2}{1:X2}{2:X2}", value.R, value.G, value.B);
                webBrowser1.Document.ExecCommand("BackColor", false, colorstr);
            }
        }
        public void SelectBodyColor()
        {
            Color color = BodyBackgroundColor;
            if (ShowColorDialog(ref color))
                BodyBackgroundColor = color;
        }
        public void SelectForeColor()
        {
            Color color = EditorForeColor;
            if (ShowColorDialog(ref color))
                EditorForeColor = color;
        }
        public void SelectBackColor()
        {
            Color color = EditorBackColor;
            if (ShowColorDialog(ref color))
                EditorBackColor = color;
        }
        /// <param name="clrs">the custorm color as a string</param>
        private static Color ConvertToColor(string clrs)
        {
            int red, green, blue;
            if (clrs.StartsWith("#"))
            {
                int clrn = Convert.ToInt32(clrs.Substring(1), 16);
                red = (clrn >> 16) & 255;
                green = (clrn >> 8) & 255;
                blue = clrn & 255;
            }
            else
            {
                int clrn = Convert.ToInt32(clrs);
                red = clrn & 255;
                green = (clrn >> 8) & 255;
                blue = (clrn >> 16) & 255;
            }
            Color incolor = Color.FromArgb(red, green, blue);
            return incolor;
        }

        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            Cut();
        }
        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            Paste();
        }
        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            Copy();
        }
        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        private void boldButton_Click(object sender, EventArgs e)
        {
            Bold();
        }

        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        private void italicButton_Click(object sender, EventArgs e)
        {
            Italic();
        }
        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        private void underlineButton_Click(object sender, EventArgs e)
        {
            Underline();
        }
        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        private void colorButton_Click(object sender, EventArgs e)
        {
            SelectForeColor();
        }
        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        private void backColorButton_Click(object sender, EventArgs e)
        {
            SelectBackColor();
        }
        /// <param name="color">the input and output color</param>
        private bool ShowColorDialog(ref Color color)
        {
            bool selected;
            using (ColorDialog dlg = new ColorDialog())
            {
                dlg.SolidColorOnly = true;
                dlg.AllowFullOpen = false;
                dlg.AnyColor = false;
                dlg.FullOpen = false;
                dlg.CustomColors = null;
                dlg.Color = color;
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    selected = true;
                    color = dlg.Color;
                }
                else
                {
                    selected = false;
                }
            }
            return selected;
        }
        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        private void imageButton_Click(object sender, EventArgs e)
        {
            InsertImage();
        }
        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        private void outdentButton_Click(object sender, EventArgs e)
        {
            Outdent();
        }
        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        private void indentButton_Click(object sender, EventArgs e)
        {
            Indent();
        }
        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cut();
        }
        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        private void copyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Copy();
        }
        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        private void pasteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Paste();
        }
        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }
        /// <param name="text">the text for which to search</param>
        /// <param name="forward">true for forward search, false for backward</param>
        /// <param name="matchWholeWord">true to match whole word, false otherwise</param>
        /// <param name="matchCase">true to match case, false otherwise</param>
        public bool Search(string text, bool forward, bool matchWholeWord, bool matchCase)
        {
            bool success = false;
            if (webBrowser1.Document != null)
            {
                IHTMLDocument2 doc =
                    webBrowser1.Document.DomDocument as IHTMLDocument2;
                IHTMLBodyElement body = doc.body as IHTMLBodyElement;
                if (body != null)
                {
                    IHTMLTxtRange range;
                    if (doc.selection != null)
                    {
                        range = doc.selection.createRange() as IHTMLTxtRange;
                        IHTMLTxtRange dup = range.duplicate();
                        dup.collapse(true);
                        if (range.isEqual(dup)) range = body.createTextRange();
                        else
                        {
                            if (forward) range.moveStart("character", 1);
                            else range.moveEnd("character", -1);
                        }
                    }
                    else range = body.createTextRange();
                    int flags = 0;
                    if (matchWholeWord) flags += 2;
                    if (matchCase) flags += 4;
                    success = range.findText(text, forward ? 999999 : -999999, flags);
                    if (success)
                    {
                        range.select();
                        range.scrollIntoView(!forward);
                    }
                }
            }
            return success;
        }
        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        private void orderedListButton_Click(object sender, EventArgs e)
        {
            OrderedList();
        }
        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        private void unorderedListButton_Click(object sender, EventArgs e)
        {
            UnorderedList();
        }

        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        private void justifyLeftButton_Click(object sender, EventArgs e)
        {
            JustifyLeft();
        }
        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        private void justifyCenterButton_Click(object sender, EventArgs e)
        {
            JustifyCenter();
        }

        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        private void justifyRightButton_Click(object sender, EventArgs e)
        {
            JustifyRight();
        }
        /// <param name="sender">the sender</param>
        /// <param name="e">EventArgs</param>
        private void justifyFullButton_Click(object sender, EventArgs e)
        {
            JustifyFull();
        }
        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectBodyColor();
        }
    }
    public enum FontSize
    {
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        NA
    }

    public enum SelectionType
    {
        Text,
        Control,
        None
    }

    public enum ReadyState
    {
        Uninitialized,
        Loading,
        Loaded,
        Interactive,
        Complete
    }

}
