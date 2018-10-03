// Decompiled with JetBrains decompiler
// Type: Proverka.MainFormLab2
// Assembly: Proverka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CEE704FC-3D12-4FFC-8D1B-D1F47A457B1E
// Assembly location: E:\Загрузки\Proverka.exe

using Microsoft.VisualBasic.CompilerServices;
using Proverka.My;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Proverka
{
  [DesignerGenerated]
  public class MainFormLab2 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("Uslovie")]
    private ListView _Uslovie;
    [AccessedThroughProperty("InterpKoeff")]
    private ListView _InterpKoeff;
    [AccessedThroughProperty("SplinesKoeff")]
    private ListView _SplinesKoeff;
    [AccessedThroughProperty("GroupBox1")]
    private GroupBox _GroupBox1;
    [AccessedThroughProperty("BtnClear")]
    private Button _BtnClear;
    [AccessedThroughProperty("BtnFigure")]
    private Button _BtnFigure;
    [AccessedThroughProperty("BtnStart")]
    private Button _BtnStart;
    [AccessedThroughProperty("Varianty")]
    private NumericUpDown _Varianty;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("GroupBox2")]
    private GroupBox _GroupBox2;
    [AccessedThroughProperty("Fout")]
    private Label _Fout;
    [AccessedThroughProperty("Sout")]
    private Label _Sout;
    [AccessedThroughProperty("XinLabel")]
    private Label _XinLabel;
    [AccessedThroughProperty("BtnCalcY")]
    private Button _BtnCalcY;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("Xin")]
    private TextBox _Xin;
    [AccessedThroughProperty("BtnExit")]
    private Button _BtnExit;
    private MyUtils ut;
    private NumericLab2 calc;
    private byte stage;
    private ListViewItem itemX;
    private ListViewItem itemY;
    private int varNo;
    private Graphics g;

    public MainFormLab2()
    {
      this.Load += new EventHandler(this.MainFormLab2_Load);
      this.FormClosed += new FormClosedEventHandler(this.MainFormLab2_FormClosed);
      this.ut = new MyUtils();
      this.calc = new NumericLab2();
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.Uslovie = new ListView();
      this.InterpKoeff = new ListView();
      this.SplinesKoeff = new ListView();
      this.GroupBox1 = new GroupBox();
      this.BtnExit = new Button();
      this.BtnClear = new Button();
      this.BtnFigure = new Button();
      this.BtnStart = new Button();
      this.Varianty = new NumericUpDown();
      this.Label1 = new Label();
      this.GroupBox2 = new GroupBox();
      this.Xin = new TextBox();
      this.Fout = new Label();
      this.Sout = new Label();
      this.XinLabel = new Label();
      this.BtnCalcY = new Button();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.Label4 = new Label();
      this.GroupBox1.SuspendLayout();
      this.Varianty.BeginInit();
      this.GroupBox2.SuspendLayout();
      this.SuspendLayout();
      this.Uslovie.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Uslovie.FullRowSelect = true;
      this.Uslovie.GridLines = true;
      ListView uslovie1 = this.Uslovie;
      Point point1 = new Point(13, 30);
      Point point2 = point1;
      uslovie1.Location = point2;
      this.Uslovie.MultiSelect = false;
      this.Uslovie.Name = "Uslovie";
      ListView uslovie2 = this.Uslovie;
      Size size1 = new Size(894, 63);
      Size size2 = size1;
      uslovie2.Size = size2;
      this.Uslovie.TabIndex = 2;
      this.Uslovie.UseCompatibleStateImageBehavior = false;
      this.Uslovie.View = View.Details;
      this.Uslovie.Visible = false;
      this.InterpKoeff.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.InterpKoeff.GridLines = true;
      ListView interpKoeff1 = this.InterpKoeff;
      point1 = new Point(13, 123);
      Point point3 = point1;
      interpKoeff1.Location = point3;
      this.InterpKoeff.Name = "InterpKoeff";
      ListView interpKoeff2 = this.InterpKoeff;
      size1 = new Size(894, 83);
      Size size3 = size1;
      interpKoeff2.Size = size3;
      this.InterpKoeff.TabIndex = 3;
      this.InterpKoeff.UseCompatibleStateImageBehavior = false;
      this.InterpKoeff.View = View.Details;
      this.InterpKoeff.Visible = false;
      this.SplinesKoeff.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.SplinesKoeff.GridLines = true;
      ListView splinesKoeff1 = this.SplinesKoeff;
      point1 = new Point(13, 234);
      Point point4 = point1;
      splinesKoeff1.Location = point4;
      this.SplinesKoeff.Name = "SplinesKoeff";
      ListView splinesKoeff2 = this.SplinesKoeff;
      size1 = new Size(651, 195);
      Size size4 = size1;
      splinesKoeff2.Size = size4;
      this.SplinesKoeff.TabIndex = 4;
      this.SplinesKoeff.UseCompatibleStateImageBehavior = false;
      this.SplinesKoeff.View = View.Details;
      this.SplinesKoeff.Visible = false;
      this.GroupBox1.Controls.Add((Control) this.BtnExit);
      this.GroupBox1.Controls.Add((Control) this.BtnClear);
      this.GroupBox1.Controls.Add((Control) this.BtnFigure);
      this.GroupBox1.Controls.Add((Control) this.BtnStart);
      this.GroupBox1.Controls.Add((Control) this.Varianty);
      this.GroupBox1.Controls.Add((Control) this.Label1);
      this.GroupBox1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      GroupBox groupBox1_1 = this.GroupBox1;
      point1 = new Point(14, 434);
      Point point5 = point1;
      groupBox1_1.Location = point5;
      this.GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = this.GroupBox1;
      size1 = new Size(893, 55);
      Size size5 = size1;
      groupBox1_2.Size = size5;
      this.GroupBox1.TabIndex = 3;
      this.GroupBox1.TabStop = false;
      this.BtnExit.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnExit1 = this.BtnExit;
      point1 = new Point(718, 16);
      Point point6 = point1;
      btnExit1.Location = point6;
      this.BtnExit.Name = "BtnExit";
      Button btnExit2 = this.BtnExit;
      size1 = new Size(138, 30);
      Size size6 = size1;
      btnExit2.Size = size6;
      this.BtnExit.TabIndex = 9;
      this.BtnExit.Text = "ВЫХОД";
      this.BtnExit.UseVisualStyleBackColor = true;
      this.BtnClear.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnClear1 = this.BtnClear;
      point1 = new Point(554, 17);
      Point point7 = point1;
      btnClear1.Location = point7;
      this.BtnClear.Name = "BtnClear";
      Button btnClear2 = this.BtnClear;
      size1 = new Size(138, 30);
      Size size7 = size1;
      btnClear2.Size = size7;
      this.BtnClear.TabIndex = 8;
      this.BtnClear.Text = "ОЧИСТИТЬ";
      this.BtnClear.UseVisualStyleBackColor = true;
      this.BtnFigure.Enabled = false;
      this.BtnFigure.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnFigure1 = this.BtnFigure;
      point1 = new Point(390, 17);
      Point point8 = point1;
      btnFigure1.Location = point8;
      this.BtnFigure.Name = "BtnFigure";
      Button btnFigure2 = this.BtnFigure;
      size1 = new Size(138, 30);
      Size size8 = size1;
      btnFigure2.Size = size8;
      this.BtnFigure.TabIndex = 7;
      this.BtnFigure.Text = "ГРАФИК";
      this.BtnFigure.UseVisualStyleBackColor = true;
      this.BtnStart.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnStart1 = this.BtnStart;
      point1 = new Point(226, 17);
      Point point9 = point1;
      btnStart1.Location = point9;
      this.BtnStart.Name = "BtnStart";
      Button btnStart2 = this.BtnStart;
      size1 = new Size(138, 30);
      Size size9 = size1;
      btnStart2.Size = size9;
      this.BtnStart.TabIndex = 1;
      this.BtnStart.Text = "СТАРТ";
      this.BtnStart.UseVisualStyleBackColor = true;
      this.Varianty.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      NumericUpDown varianty1 = this.Varianty;
      point1 = new Point(104, 20);
      Point point10 = point1;
      varianty1.Location = point10;
      NumericUpDown varianty2 = this.Varianty;
      Decimal num1 = new Decimal(new int[4]
      {
        16,
        0,
        0,
        0
      });
      Decimal num2 = num1;
      varianty2.Maximum = num2;
      NumericUpDown varianty3 = this.Varianty;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num3 = num1;
      varianty3.Minimum = num3;
      this.Varianty.Name = "Varianty";
      NumericUpDown varianty4 = this.Varianty;
      size1 = new Size(78, 26);
      Size size10 = size1;
      varianty4.Size = size10;
      this.Varianty.TabIndex = 0;
      NumericUpDown varianty5 = this.Varianty;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num4 = num1;
      varianty5.Value = num4;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label1_1 = this.Label1;
      point1 = new Point(12, 22);
      Point point11 = point1;
      label1_1.Location = point11;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(86, 20);
      Size size11 = size1;
      label1_2.Size = size11;
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Вариант:";
      this.GroupBox2.Controls.Add((Control) this.Xin);
      this.GroupBox2.Controls.Add((Control) this.Fout);
      this.GroupBox2.Controls.Add((Control) this.Sout);
      this.GroupBox2.Controls.Add((Control) this.XinLabel);
      this.GroupBox2.Controls.Add((Control) this.BtnCalcY);
      this.GroupBox2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      GroupBox groupBox2_1 = this.GroupBox2;
      point1 = new Point(681, 234);
      Point point12 = point1;
      groupBox2_1.Location = point12;
      this.GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = this.GroupBox2;
      size1 = new Size(226, 195);
      Size size12 = size1;
      groupBox2_2.Size = size12;
      this.GroupBox2.TabIndex = 4;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "4. Вычислить значение";
      this.Xin.Enabled = false;
      TextBox xin1 = this.Xin;
      point1 = new Point(56, 35);
      Point point13 = point1;
      xin1.Location = point13;
      this.Xin.MaxLength = 15;
      this.Xin.Name = "Xin";
      TextBox xin2 = this.Xin;
      size1 = new Size(154, 26);
      Size size13 = size1;
      xin2.Size = size13;
      this.Xin.TabIndex = 5;
      this.Xin.Text = "0.0";
      this.Fout.AutoSize = true;
      this.Fout.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label fout1 = this.Fout;
      point1 = new Point(19, 152);
      Point point14 = point1;
      fout1.Location = point14;
      this.Fout.Name = "Fout";
      Label fout2 = this.Fout;
      size1 = new Size(44, 20);
      Size size14 = size1;
      fout2.Size = size14;
      this.Fout.TabIndex = 10;
      this.Fout.Text = "F(X)";
      this.Fout.Visible = false;
      this.Sout.AutoSize = true;
      this.Sout.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label sout1 = this.Sout;
      point1 = new Point(19, 123);
      Point point15 = point1;
      sout1.Location = point15;
      this.Sout.Name = "Sout";
      Label sout2 = this.Sout;
      size1 = new Size(55, 20);
      Size size15 = size1;
      sout2.Size = size15;
      this.Sout.TabIndex = 9;
      this.Sout.Text = "Sn(X)";
      this.Sout.Visible = false;
      this.XinLabel.AutoSize = true;
      this.XinLabel.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label xinLabel1 = this.XinLabel;
      point1 = new Point(19, 37);
      Point point16 = point1;
      xinLabel1.Location = point16;
      this.XinLabel.Name = "XinLabel";
      Label xinLabel2 = this.XinLabel;
      size1 = new Size(31, 20);
      Size size16 = size1;
      xinLabel2.Size = size16;
      this.XinLabel.TabIndex = 8;
      this.XinLabel.Text = "X=";
      this.BtnCalcY.Enabled = false;
      this.BtnCalcY.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnCalcY1 = this.BtnCalcY;
      point1 = new Point(23, 77);
      Point point17 = point1;
      btnCalcY1.Location = point17;
      this.BtnCalcY.Name = "BtnCalcY";
      Button btnCalcY2 = this.BtnCalcY;
      size1 = new Size(187, 30);
      Size size17 = size1;
      btnCalcY2.Size = size17;
      this.BtnCalcY.TabIndex = 6;
      this.BtnCalcY.Text = "ВЫЧИСЛИТЬ F(X)";
      this.BtnCalcY.UseVisualStyleBackColor = true;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label2_1 = this.Label2;
      point1 = new Point(10, 4);
      Point point18 = point1;
      label2_1.Location = point18;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(192, 20);
      Size size18 = size1;
      label2_2.Size = size18;
      this.Label2.TabIndex = 5;
      this.Label2.Text = "1. Параметры задачи";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label3_1 = this.Label3;
      point1 = new Point(10, 96);
      Point point19 = point1;
      label3_1.Location = point19;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(290, 20);
      Size size19 = size1;
      label3_2.Size = size19;
      this.Label3.TabIndex = 6;
      this.Label3.Text = "2. Интерполяционный многочлен";
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label4_1 = this.Label4;
      point1 = new Point(10, 209);
      Point point20 = point1;
      label4_1.Location = point20;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(249, 20);
      Size size20 = size1;
      label4_2.Size = size20;
      this.Label4.TabIndex = 7;
      this.Label4.Text = "3. Коэффициенты сплайнов";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(917, 497);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.SplinesKoeff);
      this.Controls.Add((Control) this.InterpKoeff);
      this.Controls.Add((Control) this.Uslovie);
      this.Name = nameof (MainFormLab2);
      this.ShowIcon = false;
      this.Text = "ПРОВЕРКА ЛАБОРАТОРНОЙ РАБОТЫ №2";
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.Varianty.EndInit();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual ListView Uslovie
    {
      get
      {
        return this._Uslovie;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Uslovie = value;
      }
    }

    internal virtual ListView InterpKoeff
    {
      get
      {
        return this._InterpKoeff;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._InterpKoeff = value;
      }
    }

    internal virtual ListView SplinesKoeff
    {
      get
      {
        return this._SplinesKoeff;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._SplinesKoeff = value;
      }
    }

    internal virtual GroupBox GroupBox1
    {
      get
      {
        return this._GroupBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox1 = value;
      }
    }

    internal virtual Button BtnClear
    {
      get
      {
        return this._BtnClear;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._BtnClear != null)
          this._BtnClear.Click -= new EventHandler(this.BtnClear_Click);
        this._BtnClear = value;
        if (this._BtnClear == null)
          return;
        this._BtnClear.Click += new EventHandler(this.BtnClear_Click);
      }
    }

    internal virtual Button BtnFigure
    {
      get
      {
        return this._BtnFigure;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._BtnFigure != null)
          this._BtnFigure.Click -= new EventHandler(this.BtnFigure_Click);
        this._BtnFigure = value;
        if (this._BtnFigure == null)
          return;
        this._BtnFigure.Click += new EventHandler(this.BtnFigure_Click);
      }
    }

    internal virtual Button BtnStart
    {
      get
      {
        return this._BtnStart;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._BtnStart != null)
          this._BtnStart.Click -= new EventHandler(this.Start_Click);
        this._BtnStart = value;
        if (this._BtnStart == null)
          return;
        this._BtnStart.Click += new EventHandler(this.Start_Click);
      }
    }

    internal virtual NumericUpDown Varianty
    {
      get
      {
        return this._Varianty;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Varianty != null)
          this._Varianty.KeyDown -= new KeyEventHandler(this.Varianty_KeyDown);
        this._Varianty = value;
        if (this._Varianty == null)
          return;
        this._Varianty.KeyDown += new KeyEventHandler(this.Varianty_KeyDown);
      }
    }

    internal virtual Label Label1
    {
      get
      {
        return this._Label1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label1 = value;
      }
    }

    internal virtual GroupBox GroupBox2
    {
      get
      {
        return this._GroupBox2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox2 = value;
      }
    }

    internal virtual Label Fout
    {
      get
      {
        return this._Fout;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Fout = value;
      }
    }

    internal virtual Label Sout
    {
      get
      {
        return this._Sout;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Sout = value;
      }
    }

    internal virtual Label XinLabel
    {
      get
      {
        return this._XinLabel;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._XinLabel = value;
      }
    }

    internal virtual Button BtnCalcY
    {
      get
      {
        return this._BtnCalcY;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._BtnCalcY != null)
          this._BtnCalcY.Click -= new EventHandler(this.btnCalcY_Click);
        this._BtnCalcY = value;
        if (this._BtnCalcY == null)
          return;
        this._BtnCalcY.Click += new EventHandler(this.btnCalcY_Click);
      }
    }

    internal virtual Label Label2
    {
      get
      {
        return this._Label2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label2 = value;
      }
    }

    internal virtual Label Label3
    {
      get
      {
        return this._Label3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label3 = value;
      }
    }

    internal virtual Label Label4
    {
      get
      {
        return this._Label4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label4 = value;
      }
    }

    internal virtual TextBox Xin
    {
      get
      {
        return this._Xin;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Xin != null)
          this._Xin.KeyDown -= new KeyEventHandler(this.Xin_KeyDown);
        this._Xin = value;
        if (this._Xin == null)
          return;
        this._Xin.KeyDown += new KeyEventHandler(this.Xin_KeyDown);
      }
    }

    internal virtual Button BtnExit
    {
      get
      {
        return this._BtnExit;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._BtnExit != null)
          this._BtnExit.Click -= new EventHandler(this.BtnExit_Click);
        this._BtnExit = value;
        if (this._BtnExit == null)
          return;
        this._BtnExit.Click += new EventHandler(this.BtnExit_Click);
      }
    }

    private void Start_Click(object sender, EventArgs e)
    {
      switch (this.stage)
      {
        case 0:
          this.BtnStart.Text = "МНОГОЧЛЕН";
          this.varNo = int.Parse(Conversions.ToString(this.Varianty.Value));
          MyUtils ut1 = this.ut;
          Form form1 = (Form) this;
          ref Form local1 = ref form1;
          ut1.SetWaitCursor(ref local1);
          this.LoadUslovie();
          this.calc.BuildInterpolation();
          MyUtils ut2 = this.ut;
          Form form2 = (Form) this;
          ref Form local2 = ref form2;
          ut2.RestoreCursor(ref local2);
          this.Uslovie.Visible = true;
          ++this.stage;
          this.Varianty.Enabled = false;
          this.Varianty.BackColor = Color.White;
          break;
        case 1:
          this.BtnStart.Text = "СПЛАЙНЫ";
          this.LoadKoeff();
          ++this.stage;
          break;
        case 2:
          this.BtnStart.Text = "ЗАНОВО";
          this.LoadSplines();
          this.SplinesKoeff.Visible = true;
          this.Xin.Enabled = true;
          this.BtnCalcY.Enabled = true;
          this.BtnFigure.Enabled = true;
          ++this.stage;
          break;
        default:
          this.ClearAllData();
          break;
      }
    }

    private void LoadUslovie()
    {
      this.Uslovie.GridLines = true;
      this.itemX = new ListViewItem(" X ");
      this.itemY = new ListViewItem(" Y ");
      this.Uslovie.HeaderStyle = ColumnHeaderStyle.None;
      this.Uslovie.Columns.Add("", -2, HorizontalAlignment.Left);
      this.Uslovie.Items.Add(this.itemX);
      this.Uslovie.Items.Add(this.itemY);
      this.InitTaskData();
      this.Uslovie.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
    }

    private void LoadKoeff()
    {
      string str1 = "";
      string str2 = " - ";
      int num1 = 1;
      int nk1 = this.calc.NK;
      for (int index1 = num1; index1 <= nk1; ++index1)
      {
        string str3 = index1 <= 1 ? "" : " + ";
        string str4;
        switch (index1)
        {
          case 1:
            str4 = "";
            break;
          case 2:
            str4 = "X";
            break;
          default:
            str4 = "*X^" + Conversions.ToString(index1 - 1);
            break;
        }
        if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateIndexGet((object) this.calc.A, new object[1]
        {
          (object) index1
        }, (string[]) null), (object) 0.0, false))
          str1 = str1 + str3 + this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.A, new object[1]
          {
            (object) index1
          }, (string[]) null))) + str4;
        if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateIndexGet((object) this.calc.A, new object[1]
        {
          (object) index1
        }, (string[]) null), (object) 0.0, false))
        {
          string str5 = str1 + str2;
          MyUtils ut = this.ut;
          // ISSUE: variable of the null type
          __Null local1 = null;
          System.Type Type = typeof (Math);
          string MemberName = "Abs";
          object[] objArray1 = new object[1];
          object[] objArray2 = objArray1;
          int index2 = 0;
          NumericLab2 calc = this.calc;
          object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) calc.A, new object[1]
          {
            (object) index1
          }, (string[]) null));
          objArray2[index2] = objectValue;
          object[] objArray3 = objArray1;
          object[] Arguments = objArray3;
          // ISSUE: variable of the null type
          __Null local2 = null;
          // ISSUE: variable of the null type
          __Null local3 = null;
          bool[] flagArray = new bool[1]{ true };
          bool[] CopyBack = flagArray;
          object obj = NewLateBinding.LateGet((object) local1, Type, MemberName, Arguments, (string[]) local2, (System.Type[]) local3, CopyBack);
          if (flagArray[0])
            NewLateBinding.LateIndexSetComplex((object) calc.A, new object[2]
            {
              (object) index1,
              RuntimeHelpers.GetObjectValue(objArray3[0])
            }, (string[]) null, true, false);
          double dbl_in = Conversions.ToDouble(obj);
          string str6 = ut.MyDblToStr(dbl_in);
          string str7 = str4;
          str1 = str5 + str6 + str7;
        }
      }
      ListViewItem listViewItem = new ListViewItem(this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.A, new object[1]
      {
        (object) 1
      }, (string[]) null))));
      this.InterpKoeff.GridLines = true;
      int num2 = 1;
      int nk2 = this.calc.NK;
      for (int index = num2; index <= nk2; ++index)
      {
        this.InterpKoeff.Columns.Add("X^" + Conversions.ToString(index - 1), -2, HorizontalAlignment.Left);
        if (index > 1)
          listViewItem.SubItems.Add(this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.A, new object[1]
          {
            (object) index
          }, (string[]) null))));
      }
      this.InterpKoeff.Items.Add(listViewItem);
      this.InterpKoeff.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
      this.InterpKoeff.Visible = true;
    }

    private void LoadSplines()
    {
      this.SplinesKoeff.Columns.Add("i", -2, HorizontalAlignment.Left);
      this.SplinesKoeff.Columns.Add("A0", -2, HorizontalAlignment.Left);
      this.SplinesKoeff.Columns.Add("A1", -2, HorizontalAlignment.Left);
      this.SplinesKoeff.Columns.Add("A2", -2, HorizontalAlignment.Left);
      this.SplinesKoeff.Columns.Add("A3", -2, HorizontalAlignment.Left);
      this.SplinesKoeff.GridLines = true;
      int num1 = 1;
      int num2 = this.calc.NK - 1;
      for (int index = num1; index <= num2; ++index)
      {
        string str = "";
        ListViewItem listViewItem = new ListViewItem(index.ToString() + " ");
        int num3 = 1;
        do
        {
          str = str + this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.B, new object[2]
          {
            (object) num3,
            (object) index
          }, (string[]) null))) + " ";
          listViewItem.SubItems.Add(this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.B, new object[2]
          {
            (object) num3,
            (object) index
          }, (string[]) null))) + " ");
          ++num3;
        }
        while (num3 <= 4);
        this.SplinesKoeff.Items.Add(listViewItem);
      }
      this.SplinesKoeff.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
    }

    private void ClearAllData()
    {
      this.stage = (byte) -((int) this.stage + 1 == 0 ? 1 : 0);
      this.BtnStart.Text = "СТАРТ";
      this.Uslovie.Visible = false;
      this.Uslovie.Columns.Clear();
      this.SplinesKoeff.Visible = false;
      this.Varianty.Enabled = true;
      this.Uslovie.Items.Clear();
      this.SplinesKoeff.Clear();
      this.Xin.Enabled = false;
      this.Xin.Text = "0.0";
      this.BtnCalcY.Enabled = false;
      this.BtnFigure.Enabled = false;
      this.Sout.Visible = false;
      this.Fout.Visible = false;
      this.InterpKoeff.Visible = false;
      this.InterpKoeff.Clear();
    }

    private void BtnFigure_Click(object sender, EventArgs e)
    {
      object obj = (object) new Bitmap(MyProject.Forms.Plot.PictureBox1.Width, MyProject.Forms.Plot.PictureBox1.Height);
      Array instance1 = Array.CreateInstance(typeof (double), 101);
      Array instance2 = Array.CreateInstance(typeof (double), 101);
      Array instance3 = Array.CreateInstance(typeof (double), 101);
      this.g = Graphics.FromImage((Image) obj);
      MyProject.Forms.Plot.PictureBox1.Image = (Image) obj;
      int num1 = 1;
      do
      {
        NewLateBinding.LateIndexSet((object) instance1, new object[2]
        {
          (object) num1,
          Operators.AddObject(NewLateBinding.LateIndexGet((object) this.calc.X, new object[1]
          {
            (object) 1
          }, (string[]) null), Operators.DivideObject(Operators.MultiplyObject((object) (num1 - 1), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.calc.X, new object[1]
          {
            (object) this.calc.NK
          }, (string[]) null), NewLateBinding.LateIndexGet((object) this.calc.X, new object[1]
          {
            (object) 1
          }, (string[]) null))), (object) 99))
        }, (string[]) null);
        NewLateBinding.LateIndexSet((object) instance2, new object[2]
        {
          (object) num1,
          (object) 0
        }, (string[]) null);
        int num2 = 1;
        int nk = this.calc.NK;
        for (int index = num2; index <= nk; ++index)
          NewLateBinding.LateIndexSet((object) instance2, new object[2]
          {
            (object) num1,
            Operators.AddObject(NewLateBinding.LateIndexGet((object) instance2, new object[1]
            {
              (object) num1
            }, (string[]) null), Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.calc.A, new object[1]
            {
              (object) index
            }, (string[]) null), Operators.ExponentObject(NewLateBinding.LateIndexGet((object) instance1, new object[1]
            {
              (object) num1
            }, (string[]) null), (object) (index - 1))))
          }, (string[]) null);
        ++num1;
      }
      while (num1 <= 100);
      int num3 = 1;
      do
      {
        NewLateBinding.LateIndexSet((object) instance1, new object[2]
        {
          (object) num3,
          Operators.AddObject(NewLateBinding.LateIndexGet((object) this.calc.X, new object[1]
          {
            (object) 1
          }, (string[]) null), Operators.DivideObject(Operators.MultiplyObject((object) (num3 - 1), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.calc.X, new object[1]
          {
            (object) this.calc.NK
          }, (string[]) null), NewLateBinding.LateIndexGet((object) this.calc.X, new object[1]
          {
            (object) 1
          }, (string[]) null))), (object) 99))
        }, (string[]) null);
        NewLateBinding.LateIndexSet((object) instance3, new object[2]
        {
          (object) num3,
          (object) this.calc.GetValBySpline(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) instance1, new object[1]
          {
            (object) num3
          }, (string[]) null)))
        }, (string[]) null);
        ++num3;
      }
      while (num3 <= 100);
      this.ut.MyDrawFigure2(ref instance1, ref instance2, ref instance3, ref this.g, MyProject.Forms.Plot.PictureBox1.Width, MyProject.Forms.Plot.PictureBox1.Height);
      this.g.Dispose();
      MyProject.Forms.Plot.Text = "График решения";
      MyProject.Forms.Plot.HelpProvider1.SetHelpString((Control) MyProject.Forms.Plot.PictureBox1, "Синим цветом показано приближение интерполяционным полиномом. Красным цветом показано приближение сплайнами.");
      int num4 = (int) MyProject.Forms.Plot.ShowDialog((IWin32Window) this);
    }

    private void InitTaskData()
    {
      int num1;
      double[] numArray1;
      double[] numArray2;
      double[] numArray3;
      double[] numArray4;
      switch (this.varNo)
      {
        case 1:
          num1 = 7;
          MyUtils ut1 = this.ut;
          Array array1 = (Array) numArray1;
          ref Array local1 = ref array1;
          double x1_1 = 0.17453;
          double x2_1 = 0.5236;
          double x3_1 = 0.87267;
          double x4_1 = 1.22173;
          double x5_1 = 1.5708;
          double x6_1 = 1.91986;
          double x7_1 = 2.26893;
          ut1.FillArray(ref local1, x1_1, x2_1, x3_1, x4_1, x5_1, x6_1, x7_1);
          numArray2 = (double[]) array1;
          MyUtils ut2 = this.ut;
          Array array2 = (Array) numArray3;
          ref Array local2 = ref array2;
          double x1_2 = 0.00162;
          double x2_2 = 0.00252;
          double x3_2 = 0.00498;
          double x4_2 = 0.0129;
          double x5_2 = 0.03964;
          double x6_2 = 0.1207;
          double x7_2 = 0.34097;
          ut2.FillArray(ref local2, x1_2, x2_2, x3_2, x4_2, x5_2, x6_2, x7_2);
          numArray4 = (double[]) array2;
          break;
        case 2:
          num1 = 7;
          MyUtils ut3 = this.ut;
          Array array3 = (Array) numArray1;
          ref Array local3 = ref array3;
          double x1_3 = 0.17453;
          double x2_3 = 0.5236;
          double x3_3 = 0.87267;
          double x4_3 = 1.22173;
          double x5_3 = 1.5708;
          double x6_3 = 1.91986;
          double x7_3 = 2.26893;
          ut3.FillArray(ref local3, x1_3, x2_3, x3_3, x4_3, x5_3, x6_3, x7_3);
          numArray2 = (double[]) array3;
          MyUtils ut4 = this.ut;
          Array array4 = (Array) numArray3;
          ref Array local4 = ref array4;
          double x1_4 = 0.00025;
          double x2_4 = 0.00116;
          double x3_4 = 0.00361;
          double x4_4 = 0.01162;
          double x5_4 = 0.03827;
          double x6_4 = 0.11933;
          double x7_4 = 0.3396;
          ut4.FillArray(ref local4, x1_4, x2_4, x3_4, x4_4, x5_4, x6_4, x7_4);
          numArray4 = (double[]) array4;
          break;
        case 3:
          num1 = 6;
          MyUtils ut5 = this.ut;
          Array array5 = (Array) numArray1;
          ref Array local5 = ref array5;
          double x1_5 = 0.17453;
          double x2_5 = 0.5236;
          double x3_5 = 0.87267;
          double x4_5 = 1.22173;
          double x5_5 = 1.5708;
          double x6_5 = 1.91986;
          ut5.FillArray(ref local5, x1_5, x2_5, x3_5, x4_5, x5_5, x6_5);
          numArray2 = (double[]) array5;
          MyUtils ut6 = this.ut;
          Array array6 = (Array) numArray3;
          ref Array local6 = ref array6;
          double x1_6 = 3.8E-05;
          double x2_6 = 0.00052;
          double x3_6 = 0.00254;
          double x4_6 = 0.01013;
          double x5_6 = 0.03636;
          double x6_6 = 0.11699;
          ut6.FillArray(ref local6, x1_6, x2_6, x3_6, x4_6, x5_6, x6_6);
          numArray4 = (double[]) array6;
          break;
        case 4:
          num1 = 5;
          MyUtils ut7 = this.ut;
          Array array7 = (Array) numArray1;
          ref Array local7 = ref array7;
          double x1_7 = 0.17453;
          double x2_7 = 0.5236;
          double x3_7 = 0.87267;
          double x4_7 = 1.22173;
          double x5_7 = 1.5708;
          ut7.FillArray(ref local7, x1_7, x2_7, x3_7, x4_7, x5_7);
          numArray2 = (double[]) array7;
          MyUtils ut8 = this.ut;
          Array array8 = (Array) numArray3;
          ref Array local8 = ref array8;
          double x1_8 = 6E-06;
          double x2_8 = 0.00023;
          double x3_8 = 0.00173;
          double x4_8 = 0.00854;
          double x5_8 = 0.03373;
          ut8.FillArray(ref local8, x1_8, x2_8, x3_8, x4_8, x5_8);
          numArray4 = (double[]) array8;
          break;
        case 5:
          num1 = 7;
          MyUtils ut9 = this.ut;
          Array array9 = (Array) numArray1;
          ref Array local9 = ref array9;
          double x1_9 = 0.5236;
          double x2_9 = 0.87267;
          double x3_9 = 1.22173;
          double x4_9 = 1.5708;
          double x5_9 = 1.91986;
          double x6_7 = 2.26893;
          double x7_5 = 2.61799;
          ut9.FillArray(ref local9, x1_9, x2_9, x3_9, x4_9, x5_9, x6_7, x7_5);
          numArray2 = (double[]) array9;
          MyUtils ut10 = this.ut;
          Array array10 = (Array) numArray3;
          ref Array local10 = ref array10;
          double x1_10 = 0.0001;
          double x2_10 = 0.00112;
          double x3_10 = 0.00687;
          double x4_10 = 0.03018;
          double x5_10 = 0.10659;
          double x6_8 = 0.3207;
          double x7_6 = 0.85128;
          ut10.FillArray(ref local10, x1_10, x2_10, x3_10, x4_10, x5_10, x6_8, x7_6);
          numArray4 = (double[]) array10;
          break;
        case 6:
          num1 = 7;
          MyUtils ut11 = this.ut;
          Array array11 = (Array) numArray1;
          ref Array local11 = ref array11;
          double x1_11 = 0.5236;
          double x2_11 = 0.87267;
          double x3_11 = 1.22173;
          double x4_11 = 1.5708;
          double x5_11 = 1.91986;
          double x6_9 = 2.26893;
          double x7_7 = 2.61799;
          ut11.FillArray(ref local11, x1_11, x2_11, x3_11, x4_11, x5_11, x6_9, x7_7);
          numArray2 = (double[]) array11;
          MyUtils ut12 = this.ut;
          Array array12 = (Array) numArray3;
          ref Array local12 = ref array12;
          double x1_12 = 4E-05;
          double x2_12 = 0.00068;
          double x3_12 = 0.00518;
          double x4_12 = 0.02554;
          double x5_12 = 0.09624;
          double x6_10 = 0.30046;
          double x7_8 = 0.81548;
          ut12.FillArray(ref local12, x1_12, x2_12, x3_12, x4_12, x5_12, x6_10, x7_8);
          numArray4 = (double[]) array12;
          break;
        case 7:
          num1 = 6;
          MyUtils ut13 = this.ut;
          Array array13 = (Array) numArray1;
          ref Array local13 = ref array13;
          double x1_13 = 0.5236;
          double x2_13 = 0.87267;
          double x3_13 = 1.22173;
          double x4_13 = 1.5708;
          double x5_13 = 1.91986;
          double x6_11 = 2.26893;
          ut13.FillArray(ref local13, x1_13, x2_13, x3_13, x4_13, x5_13, x6_11);
          numArray2 = (double[]) array13;
          MyUtils ut14 = this.ut;
          Array array14 = (Array) numArray3;
          ref Array local14 = ref array14;
          double x1_14 = 1.4E-05;
          double x2_14 = 0.00037;
          double x3_14 = 0.00352;
          double x4_14 = 0.01971;
          double x5_14 = 0.08033;
          double x6_12 = 0.2638;
          ut14.FillArray(ref local14, x1_14, x2_14, x3_14, x4_14, x5_14, x6_12);
          numArray4 = (double[]) array14;
          break;
        case 8:
          num1 = 5;
          MyUtils ut15 = this.ut;
          Array array15 = (Array) numArray1;
          ref Array local15 = ref array15;
          double x1_15 = 0.5236;
          double x2_15 = 0.87267;
          double x3_15 = 1.22173;
          double x4_15 = 1.5708;
          double x5_15 = 1.91986;
          ut15.FillArray(ref local15, x1_15, x2_15, x3_15, x4_15, x5_15);
          numArray2 = (double[]) array15;
          MyUtils ut16 = this.ut;
          Array array16 = (Array) numArray3;
          ref Array local16 = ref array16;
          double x1_16 = 0.0;
          double x2_16 = 0.00017;
          double x3_16 = 0.00199;
          double x4_16 = 0.01282;
          double x5_16 = 0.05744;
          ut16.FillArray(ref local16, x1_16, x2_16, x3_16, x4_16, x5_16);
          numArray4 = (double[]) array16;
          break;
        case 9:
          num1 = 7;
          MyUtils ut17 = this.ut;
          Array array17 = (Array) numArray1;
          ref Array local17 = ref array17;
          double x1_17 = 0.87267;
          double x2_17 = 1.22173;
          double x3_17 = 1.5708;
          double x4_17 = 1.91986;
          double x5_17 = 2.26893;
          double x6_13 = 2.61799;
          double x7_9 = 2.967;
          ut17.FillArray(ref local17, x1_17, x2_17, x3_17, x4_17, x5_17, x6_13, x7_9);
          numArray2 = (double[]) array17;
          MyUtils ut18 = this.ut;
          Array array18 = (Array) numArray3;
          ref Array local18 = ref array18;
          double x1_18 = 0.00082;
          double x2_18 = 0.01039;
          double x3_18 = 0.07037;
          double x4_18 = 0.32762;
          double x5_18 = 1.18669;
          double x6_14 = 3.59003;
          double x7_10 = 9.4835;
          ut18.FillArray(ref local18, x1_18, x2_18, x3_18, x4_18, x5_18, x6_14, x7_10);
          numArray4 = (double[]) array18;
          break;
        case 10:
          num1 = 7;
          MyUtils ut19 = this.ut;
          Array array19 = (Array) numArray1;
          ref Array local19 = ref array19;
          double x1_19 = 0.87267;
          double x2_19 = 1.22173;
          double x3_19 = 1.5708;
          double x4_19 = 1.91986;
          double x5_19 = 2.26893;
          double x6_15 = 2.61799;
          double x7_11 = 2.96706;
          ut19.FillArray(ref local19, x1_19, x2_19, x3_19, x4_19, x5_19, x6_15, x7_11);
          numArray2 = (double[]) array19;
          MyUtils ut20 = this.ut;
          Array array20 = (Array) numArray3;
          ref Array local20 = ref array20;
          double x1_20 = 0.00123;
          double x2_20 = 0.01343;
          double x3_20 = 0.08411;
          double x4_20 = 0.37341;
          double x5_20 = 1.31146;
          double x6_16 = 3.88447;
          double x7_12 = 10.10742;
          ut20.FillArray(ref local20, x1_20, x2_20, x3_20, x4_20, x5_20, x6_16, x7_12);
          numArray4 = (double[]) array20;
          break;
        case 11:
          num1 = 6;
          MyUtils ut21 = this.ut;
          Array array21 = (Array) numArray1;
          ref Array local21 = ref array21;
          double x1_21 = 0.87267;
          double x2_21 = 1.22173;
          double x3_21 = 1.5708;
          double x4_21 = 1.91986;
          double x5_21 = 2.26893;
          double x6_17 = 2.61799;
          ut21.FillArray(ref local21, x1_21, x2_21, x3_21, x4_21, x5_21, x6_17);
          numArray2 = (double[]) array21;
          MyUtils ut22 = this.ut;
          Array array22 = (Array) numArray3;
          ref Array local22 = ref array22;
          double x1_22 = 0.00161;
          double x2_22 = 0.0155;
          double x3_22 = 0.09139;
          double x4_22 = 0.39329;
          double x5_22 = 1.35729;
          double x6_18 = 3.97819;
          ut22.FillArray(ref local22, x1_22, x2_22, x3_22, x4_22, x5_22, x6_18);
          numArray4 = (double[]) array22;
          break;
        case 12:
          num1 = 5;
          MyUtils ut23 = this.ut;
          Array array23 = (Array) numArray1;
          ref Array local23 = ref array23;
          double x1_23 = 0.87267;
          double x2_23 = 1.22173;
          double x3_23 = 1.5708;
          double x4_23 = 1.91986;
          double x5_23 = 2.26893;
          ut23.FillArray(ref local23, x1_23, x2_23, x3_23, x4_23, x5_23);
          numArray2 = (double[]) array23;
          MyUtils ut24 = this.ut;
          Array array24 = (Array) numArray3;
          ref Array local24 = ref array24;
          double x1_24 = 0.00196;
          double x2_24 = 0.01686;
          double x3_24 = 0.09511;
          double x4_24 = 0.40157;
          double x5_24 = 1.37344;
          ut24.FillArray(ref local24, x1_24, x2_24, x3_24, x4_24, x5_24);
          numArray4 = (double[]) array24;
          break;
        case 13:
          num1 = 7;
          MyUtils ut25 = this.ut;
          Array array25 = (Array) numArray1;
          ref Array local25 = ref array25;
          double x1_25 = 0.17453;
          double x2_25 = 0.5236;
          double x3_25 = 0.87267;
          double x4_25 = 1.22173;
          double x5_25 = 1.5708;
          double x6_19 = 1.91986;
          double x7_13 = 2.26893;
          ut25.FillArray(ref local25, x1_25, x2_25, x3_25, x4_25, x5_25, x6_19, x7_13);
          numArray2 = (double[]) array25;
          MyUtils ut26 = this.ut;
          Array array26 = (Array) numArray3;
          ref Array local26 = ref array26;
          double x1_26 = 3E-06;
          double x2_26 = 0.00018;
          double x3_26 = 0.00227;
          double x4_26 = 0.0177;
          double x5_26 = 0.09688;
          double x6_20 = 0.40481;
          double x7_14 = 1.37878;
          ut26.FillArray(ref local26, x1_26, x2_26, x3_26, x4_26, x5_26, x6_20, x7_14);
          numArray4 = (double[]) array26;
          break;
        case 14:
          num1 = 7;
          MyUtils ut27 = this.ut;
          Array array27 = (Array) numArray1;
          ref Array local27 = ref array27;
          double x1_27 = 0.17453;
          double x2_27 = 0.5236;
          double x3_27 = 0.87267;
          double x4_27 = 1.22173;
          double x5_27 = 1.5708;
          double x6_21 = 1.91986;
          double x7_15 = 2.26893;
          ut27.FillArray(ref local27, x1_27, x2_27, x3_27, x4_27, x5_27, x6_21, x7_15);
          numArray2 = (double[]) array27;
          MyUtils ut28 = this.ut;
          Array array28 = (Array) numArray3;
          ref Array local28 = ref array28;
          double x1_28 = 1.2E-05;
          double x2_28 = 0.00026;
          double x3_28 = 1.0 / 400.0;
          double x4_28 = 0.01815;
          double x5_28 = 0.09763;
          double x6_22 = 0.40593;
          double x7_16 = 1.38035;
          ut28.FillArray(ref local28, x1_28, x2_28, x3_28, x4_28, x5_28, x6_22, x7_16);
          numArray4 = (double[]) array28;
          break;
        case 15:
          num1 = 6;
          MyUtils ut29 = this.ut;
          Array array29 = (Array) numArray1;
          ref Array local29 = ref array29;
          double x1_29 = 1.22173;
          double x2_29 = 1.5708;
          double x3_29 = 1.91986;
          double x4_29 = 2.26893;
          double x5_29 = 2.61799;
          double x6_23 = 2.96706;
          ut29.FillArray(ref local29, x1_29, x2_29, x3_29, x4_29, x5_29, x6_23);
          numArray2 = (double[]) array29;
          MyUtils ut30 = this.ut;
          Array array30 = (Array) numArray3;
          ref Array local30 = ref array30;
          double x1_30 = 0.01834;
          double x2_30 = 0.09787;
          double x3_30 = 0.40623;
          double x4_30 = 1.3807;
          double x5_30 = 4.01752;
          double x6_24 = 10.345;
          ut30.FillArray(ref local30, x1_30, x2_30, x3_30, x4_30, x5_30, x6_24);
          numArray4 = (double[]) array30;
          break;
        case 16:
          num1 = 5;
          MyUtils ut31 = this.ut;
          Array array31 = (Array) numArray1;
          ref Array local31 = ref array31;
          double x1_31 = 1.22173;
          double x2_31 = 1.5708;
          double x3_31 = 1.91986;
          double x4_31 = 2.26893;
          double x5_31 = 2.61799;
          ut31.FillArray(ref local31, x1_31, x2_31, x3_31, x4_31, x5_31);
          numArray2 = (double[]) array31;
          MyUtils ut32 = this.ut;
          Array array32 = (Array) numArray3;
          ref Array local32 = ref array32;
          double x1_32 = 0.01849;
          double x2_32 = 0.09802;
          double x3_32 = 0.40638;
          double x4_32 = 1.38085;
          double x5_32 = 4.01768;
          ut32.FillArray(ref local32, x1_32, x2_32, x3_32, x4_32, x5_32);
          numArray4 = (double[]) array32;
          break;
      }
      int num2 = 0;
      int num3 = num1 - 1;
      for (int index = num2; index <= num3; ++index)
      {
        this.Uslovie.Columns.Add("", -2, HorizontalAlignment.Left);
        this.itemX.SubItems.Add(this.ut.MyDblToStr(numArray2[index]) + " ");
        this.itemY.SubItems.Add(this.ut.MyDblToStr(numArray4[index]) + " ");
        NewLateBinding.LateIndexSet((object) this.calc.X, new object[2]
        {
          (object) (index + 1),
          (object) numArray2[index]
        }, (string[]) null);
        NewLateBinding.LateIndexSet((object) this.calc.F, new object[3]
        {
          (object) 1,
          (object) (index + 1),
          (object) numArray4[index]
        }, (string[]) null);
      }
      this.calc.NK = num1;
    }

    private void BtnClear_Click(object sender, EventArgs e)
    {
      this.ClearAllData();
    }

    private void btnCalcY_Click(object sender, EventArgs e)
    {
      this.CalculateY();
    }

    private void Xin_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Return)
        this.CalculateY();
      else
        this.ut.MyCheckNumKeyDown(ref e);
    }

    private void CalculateY()
    {
      bool bres = false;
      MyUtils ut = this.ut;
      TextBox xin = this.Xin;
      ref TextBox local = ref xin;
      int num = ut.MyCheckNumValue(ref local) ? 1 : 0;
      this.Xin = xin;
      if (num == 0)
        return;
      double Sval;
      int Snum;
      double Fval;
      this.calc.CalculateY(this.ut.MyStrToDbl(this.Xin.Text), ref Sval, ref Snum, ref Fval, ref bres);
      if (bres)
      {
        this.Sout.Text = "S" + Conversions.ToString(Snum) + "(X) = " + this.ut.MyDblToStr(Sval);
        this.Fout.Text = "P(X) = " + this.ut.MyDblToStr(Fval);
      }
      else
      {
        this.Sout.Text = "Ошибка!";
        this.Fout.Text = "Ошибка!";
      }
      this.Sout.Visible = true;
      this.Fout.Visible = true;
    }

    private void BtnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void MainFormLab2_Load(object sender, EventArgs e)
    {
      MyProject.Forms.Plot.HelpProvider1.SetHelpString((Control) MyProject.Forms.Plot.PictureBox1, "Синим цветом показаны значения, вычисленные с помощью интерполяционного полинома.Красным цветом показаны значения, вычисленные с помощью сплайнов.");
    }

    private void Varianty_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyValue != 13)
        return;
      this.BtnStart.PerformClick();
    }

    private void MainFormLab2_FormClosed(object sender, FormClosedEventArgs e)
    {
      MyProject.Forms.Proverka.Show();
    }
  }
}
