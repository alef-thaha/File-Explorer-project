﻿#pragma checksum "C:\Users\alef-pt4023\source\repos\File Explorer project\File Explorer project\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "56619525629AC853EB2EA8D60A677A503B61AAC6363FB494EC4CCA10CB11073A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace File_Explorer_project
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 13
                {
                    this.MainGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)this.MainGrid).Loaded += this.MainGrid_Loaded;
                }
                break;
            case 3: // MainPage.xaml line 18
                {
                    this.Narrowlayotwidth = (global::Windows.UI.Xaml.AdaptiveTrigger)(target);
                }
                break;
            case 4: // MainPage.xaml line 83
                {
                    this.columnone = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 5: // MainPage.xaml line 84
                {
                    this.columntwo = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 6: // MainPage.xaml line 95
                {
                    this.FolderStackpanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 7: // MainPage.xaml line 155
                {
                    this.ListGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 8: // MainPage.xaml line 176
                {
                    this.Detailstackpanel = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)this.Detailstackpanel).Loaded += this.Detailstackpanel_Loaded;
                }
                break;
            case 9: // MainPage.xaml line 189
                {
                    this.DetailsTextblock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // MainPage.xaml line 190
                {
                    this.Filename = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // MainPage.xaml line 191
                {
                    this.Filenametext = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // MainPage.xaml line 195
                {
                    this.Filepath = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // MainPage.xaml line 196
                {
                    this.Filepathtext = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14: // MainPage.xaml line 199
                {
                    this.Filedate = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15: // MainPage.xaml line 200
                {
                    this.Filedatetext = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16: // MainPage.xaml line 203
                {
                    this.Filemodifieddate = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17: // MainPage.xaml line 204
                {
                    this.FileModifieddatetext = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18: // MainPage.xaml line 207
                {
                    this.Filesize = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19: // MainPage.xaml line 208
                {
                    this.Filesizetext = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 20: // MainPage.xaml line 160
                {
                    this.ListTextblock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 21: // MainPage.xaml line 161
                {
                    this.FoldersListview = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.FoldersListview).ItemClick += this.FoldersListview_ItemClick;
                }
                break;
            case 24: // MainPage.xaml line 97
                {
                    this.DetailViewBack = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.DetailViewBack).Click += this.DetailViewBack_Click;
                    ((global::Windows.UI.Xaml.Controls.Button)this.DetailViewBack).PointerMoved += this.DetailViewBack_PointerMoved;
                }
                break;
            case 25: // MainPage.xaml line 104
                {
                    this.BackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BackButton).Click += this.BackButton_Click;
                    ((global::Windows.UI.Xaml.Controls.Button)this.BackButton).PointerMoved += this.BackButton_PointerMoved;
                    ((global::Windows.UI.Xaml.Controls.Button)this.BackButton).PointerPressed += this.BackButton_PointerPressed;
                }
                break;
            case 26: // MainPage.xaml line 110
                {
                    this.PicturesButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.PicturesButton).Click += this.PicturesButton_Click;
                    ((global::Windows.UI.Xaml.Controls.Button)this.PicturesButton).PointerMoved += this.PicturesButton_PointerMoved;
                }
                break;
            case 27: // MainPage.xaml line 116
                {
                    this.MusicButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.MusicButton).Click += this.MusicButton_Click;
                    ((global::Windows.UI.Xaml.Controls.Button)this.MusicButton).PointerMoved += this.MusicButton_PointerMoved;
                }
                break;
            case 28: // MainPage.xaml line 122
                {
                    this.VideoButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.VideoButton).Click += this.VideoButton_Click;
                    ((global::Windows.UI.Xaml.Controls.Button)this.VideoButton).PointerMoved += this.VideoButton_PointerMoved;
                }
                break;
            case 29: // MainPage.xaml line 128
                {
                    this.ObjectButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ObjectButton).Click += this.ObjectButton_Click;
                    ((global::Windows.UI.Xaml.Controls.Button)this.ObjectButton).PointerMoved += this.ObjectButton_PointerMoved;
                }
                break;
            case 30: // MainPage.xaml line 134
                {
                    this.DocumentsButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.DocumentsButton).Click += this.DocumentsButton_Click;
                    ((global::Windows.UI.Xaml.Controls.Button)this.DocumentsButton).PointerMoved += this.DocumentsButton_PointerMoved;
                }
                break;
            case 31: // MainPage.xaml line 140
                {
                    this.FileButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.FileButton).Click += this.FileButton_Click;
                    ((global::Windows.UI.Xaml.Controls.Button)this.FileButton).PointerMoved += this.FileButton_PointerMoved;
                }
                break;
            case 32: // MainPage.xaml line 146
                {
                    this.FolderButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.FolderButton).Click += this.FolderButton_Click;
                    ((global::Windows.UI.Xaml.Controls.Button)this.FolderButton).PointerMoved += this.FolderButton_PointerMoved;
                }
                break;
            case 33: // MainPage.xaml line 149
                {
                    this.FolderTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 34: // MainPage.xaml line 143
                {
                    this.FileTextblock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 35: // MainPage.xaml line 137
                {
                    this.DocumentTextblock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 36: // MainPage.xaml line 131
                {
                    this.ObjectTextblock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 37: // MainPage.xaml line 125
                {
                    this.VideoTextblock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 38: // MainPage.xaml line 119
                {
                    this.MusicTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 39: // MainPage.xaml line 113
                {
                    this.PicturesTextblock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 40: // MainPage.xaml line 107
                {
                    this.Backtextblock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 41: // MainPage.xaml line 101
                {
                    this.Hamburgerbutton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Hamburgerbutton).PointerMoved += this.Hamburgerbutton_PointerMoved;
                }
                break;
            case 42: // MainPage.xaml line 102
                {
                    this.Folderstext = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

