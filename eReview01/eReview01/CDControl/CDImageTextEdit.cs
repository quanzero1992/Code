using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;

namespace ImageTextEdit
{
  [UserRepositoryItem("RepositoryItemImageTextEdit")]
  public class RepositoryItemImageTextEdit : RepositoryItemTextEdit
  {
    private object imageList;
    private int imageIndex;
    private HorzAlignment imageAlignment;

    static RepositoryItemImageTextEdit()
    {
      RegisterCustomIconTextEdit();
    }

    public RepositoryItemImageTextEdit()
    {
      imageList = null;
      imageIndex = -1;
      imageAlignment = HorzAlignment.Default;
    }

    public const string CustomIconTextEditName = "ImageTextEdit";

    public override string EditorTypeName
    {
      get { return CustomIconTextEditName; }
    }

    public static void RegisterCustomIconTextEdit()
    {
      EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomIconTextEditName,
        typeof(ImageTextEdit), typeof(RepositoryItemImageTextEdit),
        typeof(TextEditViewInfo), new TextEditPainter(), true));
    }


    public override void Assign(RepositoryItem item)
    {
      base.Assign(item);
      RepositoryItemImageTextEdit source = item as RepositoryItemImageTextEdit;
      Events.AddHandler(_iconClick, source.Events[_iconClick]);
      Events.AddHandler(_onIconSelection, source.Events[_onIconSelection]);
      this.imageList = source.ImageList;
      this.imageIndex = source.ImageIndex;
      this.imageAlignment = source.imageAlignment;
    }

    private static readonly object _iconClick = new object();
    private static readonly object _onIconSelection = new object();

    public event IconClickEventHandler IconClick
    {
      add { this.Events.AddHandler(_iconClick, value); }
      remove { this.Events.RemoveHandler(_iconClick, value); }
    }

    protected internal virtual void RaiseIconClick(MouseEventArgs e)
    {
      IconClickEventHandler handler = (IconClickEventHandler)Events[_iconClick];
      if (handler != null) handler(GetEventSender(), e);
    }

    internal bool CanRaiseBeforeEditValueLoaded
    {
      get { return (IconClickEventHandler)Events[_iconClick] != null; }
    }

    public event OnIconSelectionEventHandler OnIconSelection
    {
      add { this.Events.AddHandler(_onIconSelection, value); }
      remove { this.Events.RemoveHandler(_onIconSelection, value); }
    }

    protected internal virtual void RaiseOnIconSelection(OnIconSelectionEventArgs e)
    {
      OnIconSelectionEventHandler handler = (OnIconSelectionEventHandler)Events[_onIconSelection];
      if (handler != null) handler(GetEventSender(), e);
    }


    [Description("Gets or sets the source of images to be displayed within the editor.")]
    [Category(CategoryName.Appearance)]
    [TypeConverter(typeof(DevExpress.Utils.Design.ImageCollectionImagesConverter))]
    public virtual object ImageList
    {
      get { return imageList; }
      set
      {
        if (ImageList == value) return;
        imageList = value;
        OnPropertiesChanged();
      }
    }

    [Description("Gets or sets the index of the image displayed on the editor.")]
    [Category(CategoryName.Appearance)]
    [DefaultValue(-1)]
    [Editor(typeof(DevExpress.Utils.Design.ImageIndexesEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [ImageList("ImageList")]
    public virtual int ImageIndex
    {
      get { return imageIndex; }
      set
      {
        if (ImageIndex == value) return;
        imageIndex = value;
        OnPropertiesChanged();
      }
    }

    public HorzAlignment ImageAlignment
    {
      get { return imageAlignment; }
      set
      {
        if (ImageAlignment == value) return;
        imageAlignment = value;
        OnPropertiesChanged();
      }
    }

    public override BaseEditViewInfo CreateViewInfo()
    {
      return new ImageTextEditViewInfo(this);
    }

    public override BaseEditPainter CreatePainter()
    {
      return new ImageTextEditPainter();
    }
  }

  public delegate void IconClickEventHandler(object sender, MouseEventArgs e);

  public delegate void OnIconSelectionEventHandler(object sender, OnIconSelectionEventArgs e);

  public class OnIconSelectionEventArgs : EventArgs
  {
    private int imageIndex;
    private readonly object imageList;

    public OnIconSelectionEventArgs(object iconCollection, int iconIndex)
    {
      this.imageList = iconCollection;
      this.imageIndex = iconIndex;
    }

    public virtual int ImageIndex
    {
      get { return imageIndex; }
      set { imageIndex = value; }
    }

    public virtual object ImageList
    {
      get { return imageList; }
    }
  }

  public class ImageTextEdit : TextEdit
  {
    static ImageTextEdit()
    {
      RepositoryItemImageTextEdit.RegisterCustomIconTextEdit();
    }

    public override string EditorTypeName
    {
      get { return RepositoryItemImageTextEdit.CustomIconTextEditName; }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public new RepositoryItemImageTextEdit Properties
    {
      get { return base.Properties as RepositoryItemImageTextEdit; }
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
      ImageTextEditViewInfo vi = ViewInfo as ImageTextEditViewInfo;
      if (vi.IsIconClick(e.Location))
      {
        int newX = e.X - vi.IconRect.Left;
        int newY = e.Y - vi.IconRect.Top;
        MouseEventArgs ee = new MouseEventArgs(e.Button, e.Clicks, newX, newY, e.Delta);
        Properties.RaiseIconClick(ee);
      }
      base.OnMouseDown(e);
    }

    public event IconClickEventHandler IconClick
    {
      add { this.Properties.IconClick += value; }
      remove { this.Properties.IconClick -= value; }
    }
  }

  public class ImageTextEditViewInfo : TextEditViewInfo
  {
    private Rectangle fIconRect;
    private const int SeparatorWidth = 3;

    public ImageTextEditViewInfo(RepositoryItem item)
      : base(item)
    {
      fIconRect = Rectangle.Empty;
    }


    protected internal virtual bool IsIconClick(Point p)
    {
      return (p.X > IconRect.Left) && (p.X < IconRect.Right) && (p.Y > IconRect.Top) && (p.Y < IconRect.Bottom);
    }

    public object ImageList
    {
      get { return Item.ImageList; }
    }

    public int ImageIndex
    {
      get { return Item.ImageIndex; }
    }

    public new virtual RepositoryItemImageTextEdit Item
    {
      get { return base.Item as RepositoryItemImageTextEdit; }
    }

    protected override void Assign(BaseControlViewInfo info)
    {
      base.Assign(info);
      ImageTextEditViewInfo be = info as ImageTextEditViewInfo;
      if (be == null) return;
      this.fIconRect = be.fIconRect;
    }

    public override Size CalcBestFit(Graphics g)
    {
      Size s = base.CalcBestFit(g);
      s.Width = s.Width + SeparatorWidth * 2 + GetImageSize().Width;
      return s;
    }

    protected internal virtual Rectangle IconRect
    {
      get { return fIconRect; }
      set { fIconRect = value; }
    }

    public override void Offset(int x, int y)
    {
      base.Offset(x, y);
      if (!fIconRect.IsEmpty)
        this.fIconRect.Offset(x, y);
    }

    //protected override Rectangle CalcMaskBoxRect(Rectangle content)
    //{
    //  if (Item.ImageAlignment == HorzAlignment.Center)
    //  {
    //    return Rectangle.Empty;
    //  }

    //  Rectangle r = base.CalcMaskBoxRect(content);
    //  int iconWidth = GetImageSize().Width + SeparatorWidth;

    //  r.Width -= iconWidth;
    //  if (Item.ImageAlignment != HorzAlignment.Far)
    //  {
    //    r.X += iconWidth;
    //  }
    //  return r;
    //}

    protected override void CalcContentRect(Rectangle bounds)
    {
      base.CalcContentRect(bounds);
      this.fIconRect = CalcIconRect(bounds);
    }

    protected virtual Rectangle CalcIconRect(Rectangle content)
    {
      Rectangle r = content;
      r.Size = GetImageSize();

      if (Item.ImageAlignment == HorzAlignment.Center)
      {
        r.X = content.X + content.Width / 2 - GetImageSize().Width / 2;
      }
      if (Item.ImageAlignment == HorzAlignment.Far)
      {
        r.X = MaskBoxRect.Right + SeparatorWidth;
      }
      return r;
    }

    protected Size GetImageSize()
    {
      ImageCollection ic = ImageList as ImageCollection;
      if (ic != null)
        return ic.ImageSize;
      return new Size(0, 0);
    }

    protected override int CalcMinHeightCore(Graphics g)
    {
      int imageHeight = 0;
      if (ImageList != null)
      {
        imageHeight = GetImageSize().Height;
        if (AllowDrawFocusRect)
          imageHeight += (FocusRectThin + 1) * 2;
      }
      int fontHeight = base.CalcMinHeightCore(g);
      return (imageHeight > fontHeight) ? imageHeight : fontHeight;
    }
  }

  public class ImageTextEditPainter : TextEditPainter
  {
    protected override void DrawContent(ControlGraphicsInfoArgs info)
    {
      base.DrawContent(info);
      ImageTextEditViewInfo vi = info.ViewInfo as ImageTextEditViewInfo;
      if (vi.MaskBoxRect.IsEmpty)
        info.Cache.FillRectangle(vi.PaintAppearance.GetBackBrush(info.Cache), info.Bounds);
      DrawIcon(info);
    }

    protected virtual void DrawIcon(ControlGraphicsInfoArgs info)
    {
      ImageTextEditViewInfo vi = info.ViewInfo as ImageTextEditViewInfo;
      OnIconSelectionEventArgs e = new OnIconSelectionEventArgs(vi.ImageList, vi.ImageIndex);
      vi.Item.RaiseOnIconSelection(e);

      // calculate vertical offset to center icon vertically
      int offsetY = (info.Bounds.Height / 2) - (vi.IconRect.Height / 2);
      Rectangle iconRect = vi.IconRect;
      iconRect.Y += offsetY;

      if (e.ImageList != null && e.ImageIndex != -1)
        info.Cache.Paint.DrawImage(info.Cache, e.ImageList, e.ImageIndex, iconRect, true);
      else
        info.Graphics.FillRectangle(info.Cache.GetSolidBrush(Color.White), vi.IconRect);
    }
  }

  public interface IIconSelector
  {
    event OnIconSelectionEventHandler OnIconSelection;
  }
}