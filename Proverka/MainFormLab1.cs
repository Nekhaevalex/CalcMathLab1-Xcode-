// Decompiled with JetBrains decompiler
// Type: Proverka.MainFormLab1
// Assembly: Proverka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CEE704FC-3D12-4FFC-8D1B-D1F47A457B1E
// Assembly location: E:\Загрузки\Proverka.exe

using Microsoft.VisualBasic.CompilerServices;
using Proverka.My;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Proverka
{
  [DesignerGenerated]
  public class MainFormLab1 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("Koeff")]
    private ListBox _Koeff;
    [AccessedThroughProperty("Otrezki")]
    private ListBox _Otrezki;
    [AccessedThroughProperty("Korni")]
    private ListBox _Korni;
    [AccessedThroughProperty("Uslovie")]
    private ListBox _Uslovie;
    [AccessedThroughProperty("VariantNum")]
    private NumericUpDown _VariantNum;
    [AccessedThroughProperty("ZadachaNum")]
    private NumericUpDown _ZadachaNum;
    [AccessedThroughProperty("BtnStart")]
    private Button _BtnStart;
    [AccessedThroughProperty("ClearAllBtn")]
    private Button _ClearAllBtn;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("GroupBox1")]
    private GroupBox _GroupBox1;
    [AccessedThroughProperty("TabOtveti")]
    private TabControl _TabOtveti;
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;
    [AccessedThroughProperty("BtnExit")]
    private Button _BtnExit;
    private MyUtils ut;
    private NumericLab1 calc;
    private byte istage;
    private StreamReader fileReader;
    private string strReader;
    public int varNo;
    public int taskNo;
    private Array ParamName;
    private Array ParamNameRes;
    private Array RazmerName;
    private Array RazmerNameRes;

    public MainFormLab1()
    {
      this.FormClosed += new FormClosedEventHandler(this.MainFormLab1_FormClosed);
      this.ut = new MyUtils();
      this.calc = new NumericLab1();
      this.ParamName = Array.CreateInstance(typeof (string), 11);
      this.ParamNameRes = Array.CreateInstance(typeof (string), 13);
      this.RazmerName = Array.CreateInstance(typeof (string), 11);
      this.RazmerNameRes = Array.CreateInstance(typeof (string), 13);
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
      this.Koeff = new ListBox();
      this.Otrezki = new ListBox();
      this.Korni = new ListBox();
      this.Uslovie = new ListBox();
      this.VariantNum = new NumericUpDown();
      this.ZadachaNum = new NumericUpDown();
      this.BtnStart = new Button();
      this.ClearAllBtn = new Button();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.Label4 = new Label();
      this.Label5 = new Label();
      this.Label6 = new Label();
      this.GroupBox1 = new GroupBox();
      this.TabOtveti = new TabControl();
      this.Panel1 = new Panel();
      this.BtnExit = new Button();
      this.VariantNum.BeginInit();
      this.ZadachaNum.BeginInit();
      this.GroupBox1.SuspendLayout();
      this.Panel1.SuspendLayout();
      this.SuspendLayout();
      this.Koeff.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Koeff.FormattingEnabled = true;
      this.Koeff.ItemHeight = 20;
      ListBox koeff1 = this.Koeff;
      Point point1 = new Point(12, 31);
      Point point2 = point1;
      koeff1.Location = point2;
      this.Koeff.Name = "Koeff";
      ListBox koeff2 = this.Koeff;
      Size size1 = new Size(345, 144);
      Size size2 = size1;
      koeff2.Size = size2;
      this.Koeff.TabIndex = 5;
      this.Otrezki.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Otrezki.FormattingEnabled = true;
      this.Otrezki.ItemHeight = 20;
      ListBox otrezki1 = this.Otrezki;
      point1 = new Point(12, 217);
      Point point3 = point1;
      otrezki1.Location = point3;
      this.Otrezki.Name = "Otrezki";
      ListBox otrezki2 = this.Otrezki;
      size1 = new Size(345, 104);
      Size size3 = size1;
      otrezki2.Size = size3;
      this.Otrezki.TabIndex = 6;
      this.Korni.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Korni.FormattingEnabled = true;
      this.Korni.ItemHeight = 20;
      ListBox korni1 = this.Korni;
      point1 = new Point(12, 357);
      Point point4 = point1;
      korni1.Location = point4;
      this.Korni.Name = "Korni";
      ListBox korni2 = this.Korni;
      size1 = new Size(345, 84);
      Size size4 = size1;
      korni2.Size = size4;
      this.Korni.TabIndex = 7;
      this.Uslovie.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Uslovie.FormattingEnabled = true;
      this.Uslovie.ItemHeight = 20;
      ListBox uslovie1 = this.Uslovie;
      point1 = new Point(4, 24);
      Point point5 = point1;
      uslovie1.Location = point5;
      this.Uslovie.Name = "Uslovie";
      ListBox uslovie2 = this.Uslovie;
      size1 = new Size(238, 244);
      Size size5 = size1;
      uslovie2.Size = size5;
      this.Uslovie.TabIndex = 4;
      this.VariantNum.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      NumericUpDown variantNum1 = this.VariantNum;
      point1 = new Point(28, 300);
      Point point6 = point1;
      variantNum1.Location = point6;
      NumericUpDown variantNum2 = this.VariantNum;
      Decimal num1 = new Decimal(new int[4]
      {
        4,
        0,
        0,
        0
      });
      Decimal num2 = num1;
      variantNum2.Maximum = num2;
      NumericUpDown variantNum3 = this.VariantNum;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num3 = num1;
      variantNum3.Minimum = num3;
      this.VariantNum.Name = "VariantNum";
      NumericUpDown variantNum4 = this.VariantNum;
      size1 = new Size(73, 26);
      Size size6 = size1;
      variantNum4.Size = size6;
      this.VariantNum.TabIndex = 0;
      NumericUpDown variantNum5 = this.VariantNum;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num4 = num1;
      variantNum5.Value = num4;
      this.ZadachaNum.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      NumericUpDown zadachaNum1 = this.ZadachaNum;
      point1 = new Point(160, 300);
      Point point7 = point1;
      zadachaNum1.Location = point7;
      NumericUpDown zadachaNum2 = this.ZadachaNum;
      num1 = new Decimal(new int[4]{ 8, 0, 0, 0 });
      Decimal num5 = num1;
      zadachaNum2.Maximum = num5;
      NumericUpDown zadachaNum3 = this.ZadachaNum;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num6 = num1;
      zadachaNum3.Minimum = num6;
      this.ZadachaNum.Name = "ZadachaNum";
      NumericUpDown zadachaNum4 = this.ZadachaNum;
      size1 = new Size(73, 26);
      Size size7 = size1;
      zadachaNum4.Size = size7;
      this.ZadachaNum.TabIndex = 1;
      NumericUpDown zadachaNum5 = this.ZadachaNum;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num7 = num1;
      zadachaNum5.Value = num7;
      this.BtnStart.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnStart1 = this.BtnStart;
      point1 = new Point(27, 331);
      Point point8 = point1;
      btnStart1.Location = point8;
      this.BtnStart.Name = "BtnStart";
      Button btnStart2 = this.BtnStart;
      size1 = new Size(205, 29);
      Size size8 = size1;
      btnStart2.Size = size8;
      this.BtnStart.TabIndex = 2;
      this.BtnStart.Text = "СТАРТ";
      this.BtnStart.UseVisualStyleBackColor = true;
      this.ClearAllBtn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button clearAllBtn1 = this.ClearAllBtn;
      point1 = new Point(27, 364);
      Point point9 = point1;
      clearAllBtn1.Location = point9;
      this.ClearAllBtn.Name = "ClearAllBtn";
      Button clearAllBtn2 = this.ClearAllBtn;
      size1 = new Size(205, 29);
      Size size9 = size1;
      clearAllBtn2.Size = size9;
      this.ClearAllBtn.TabIndex = 3;
      this.ClearAllBtn.Text = "ОЧИСТИТЬ";
      this.ClearAllBtn.UseVisualStyleBackColor = true;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label1_1 = this.Label1;
      point1 = new Point(12, 7);
      Point point10 = point1;
      label1_1.Location = point10;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(252, 20);
      Size size10 = size1;
      label1_2.Size = size10;
      this.Label1.TabIndex = 9;
      this.Label1.Text = "1. Коэффициенты полинома";
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label2_1 = this.Label2;
      point1 = new Point(12, 191);
      Point point11 = point1;
      label2_1.Location = point11;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(215, 20);
      Size size11 = size1;
      label2_2.Size = size11;
      this.Label2.TabIndex = 10;
      this.Label2.Text = "2. Отрезки локализации";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label3_1 = this.Label3;
      point1 = new Point(12, 332);
      Point point12 = point1;
      label3_1.Location = point12;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(80, 20);
      Size size12 = size1;
      label3_2.Size = size12;
      this.Label3.TabIndex = 11;
      this.Label3.Text = "3. Корни";
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label4_1 = this.Label4;
      point1 = new Point(31, 1);
      Point point13 = point1;
      label4_1.Location = point13;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(172, 20);
      Size size13 = size1;
      label4_2.Size = size13;
      this.Label4.TabIndex = 12;
      this.Label4.Text = "Параметры задачи";
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label5_1 = this.Label5;
      point1 = new Point(24, 277);
      Point point14 = point1;
      label5_1.Location = point14;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(81, 20);
      Size size14 = size1;
      label5_2.Size = size14;
      this.Label5.TabIndex = 13;
      this.Label5.Text = "Вариант";
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label6_1 = this.Label6;
      point1 = new Point(156, 277);
      Point point15 = point1;
      label6_1.Location = point15;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(73, 20);
      Size size15 = size1;
      label6_2.Size = size15;
      this.Label6.TabIndex = 14;
      this.Label6.Text = "Задача";
      this.GroupBox1.Controls.Add((Control) this.TabOtveti);
      this.GroupBox1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      GroupBox groupBox1_1 = this.GroupBox1;
      point1 = new Point(363, 12);
      Point point16 = point1;
      groupBox1_1.Location = point16;
      this.GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = this.GroupBox1;
      size1 = new Size(298, 430);
      Size size16 = size1;
      groupBox1_2.Size = size16;
      this.GroupBox1.TabIndex = 15;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "4. Ответ";
      this.TabOtveti.Appearance = TabAppearance.FlatButtons;
      this.TabOtveti.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TabControl tabOtveti1 = this.TabOtveti;
      point1 = new Point(6, 19);
      Point point17 = point1;
      tabOtveti1.Location = point17;
      this.TabOtveti.Name = "TabOtveti";
      this.TabOtveti.SelectedIndex = 0;
      TabControl tabOtveti2 = this.TabOtveti;
      size1 = new Size(286, 396);
      Size size17 = size1;
      tabOtveti2.Size = size17;
      this.TabOtveti.TabIndex = 8;
      this.Panel1.BorderStyle = BorderStyle.Fixed3D;
      this.Panel1.Controls.Add((Control) this.BtnExit);
      this.Panel1.Controls.Add((Control) this.Label5);
      this.Panel1.Controls.Add((Control) this.VariantNum);
      this.Panel1.Controls.Add((Control) this.BtnStart);
      this.Panel1.Controls.Add((Control) this.ZadachaNum);
      this.Panel1.Controls.Add((Control) this.ClearAllBtn);
      this.Panel1.Controls.Add((Control) this.Label6);
      this.Panel1.Controls.Add((Control) this.Label4);
      this.Panel1.Controls.Add((Control) this.Uslovie);
      Panel panel1_1 = this.Panel1;
      point1 = new Point(677, 12);
      Point point18 = point1;
      panel1_1.Location = point18;
      this.Panel1.Name = "Panel1";
      Panel panel1_2 = this.Panel1;
      size1 = new Size(250, 430);
      Size size18 = size1;
      panel1_2.Size = size18;
      this.Panel1.TabIndex = 17;
      this.BtnExit.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnExit1 = this.BtnExit;
      point1 = new Point(27, 397);
      Point point19 = point1;
      btnExit1.Location = point19;
      this.BtnExit.Name = "BtnExit";
      Button btnExit2 = this.BtnExit;
      size1 = new Size(205, 29);
      Size size19 = size1;
      btnExit2.Size = size19;
      this.BtnExit.TabIndex = 15;
      this.BtnExit.Text = "ВЫХОД";
      this.BtnExit.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.AutoSize = true;
      size1 = new Size(936, 452);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Korni);
      this.Controls.Add((Control) this.Panel1);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.Otrezki);
      this.Controls.Add((Control) this.Koeff);
      this.Controls.Add((Control) this.Label1);
      this.MinimizeBox = false;
      this.Name = nameof (MainFormLab1);
      this.ShowIcon = false;
      this.Text = "ПРОВЕРКА ЛАБОРАТОРНОЙ РАБОТЫ №1";
      this.VariantNum.EndInit();
      this.ZadachaNum.EndInit();
      this.GroupBox1.ResumeLayout(false);
      this.Panel1.ResumeLayout(false);
      this.Panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual ListBox Koeff
    {
      get
      {
        return this._Koeff;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Koeff = value;
      }
    }

    internal virtual ListBox Otrezki
    {
      get
      {
        return this._Otrezki;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Otrezki = value;
      }
    }

    internal virtual ListBox Korni
    {
      get
      {
        return this._Korni;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Korni = value;
      }
    }

    internal virtual ListBox Uslovie
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

    internal virtual NumericUpDown VariantNum
    {
      get
      {
        return this._VariantNum;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._VariantNum != null)
          this._VariantNum.KeyDown -= new KeyEventHandler(this.VariantNum_KeyDown);
        this._VariantNum = value;
        if (this._VariantNum == null)
          return;
        this._VariantNum.KeyDown += new KeyEventHandler(this.VariantNum_KeyDown);
      }
    }

    internal virtual NumericUpDown ZadachaNum
    {
      get
      {
        return this._ZadachaNum;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ZadachaNum != null)
          this._ZadachaNum.KeyDown -= new KeyEventHandler(this.ZadachaNum_KeyDown);
        this._ZadachaNum = value;
        if (this._ZadachaNum == null)
          return;
        this._ZadachaNum.KeyDown += new KeyEventHandler(this.ZadachaNum_KeyDown);
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

    internal virtual Button ClearAllBtn
    {
      get
      {
        return this._ClearAllBtn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ClearAllBtn != null)
          this._ClearAllBtn.Click -= new EventHandler(this.ClearAllBtn_Click);
        this._ClearAllBtn = value;
        if (this._ClearAllBtn == null)
          return;
        this._ClearAllBtn.Click += new EventHandler(this.ClearAllBtn_Click);
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

    internal virtual Label Label5
    {
      get
      {
        return this._Label5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label5 = value;
      }
    }

    internal virtual Label Label6
    {
      get
      {
        return this._Label6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label6 = value;
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

    internal virtual TabControl TabOtveti
    {
      get
      {
        return this._TabOtveti;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TabOtveti = value;
      }
    }

    internal virtual Panel Panel1
    {
      get
      {
        return this._Panel1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Panel1 = value;
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
      switch (this.istage)
      {
        case 0:
          this.BtnStart.Text = "КОЭФФИЦИЕНТЫ";
          this.varNo = int.Parse(Conversions.ToString(this.VariantNum.Value));
          this.taskNo = int.Parse(Conversions.ToString(this.ZadachaNum.Value));
          this.LoadUslovie();
          this.Uslovie.Visible = true;
          ++this.istage;
          this.VariantNum.Enabled = false;
          this.VariantNum.BackColor = Color.White;
          this.ZadachaNum.Enabled = false;
          this.ZadachaNum.BackColor = Color.White;
          break;
        case 1:
          this.BtnStart.Text = "ОТРЕЗКИ";
          MyUtils ut1 = this.ut;
          Form form1 = (Form) this;
          ref Form local1 = ref form1;
          ut1.SetWaitCursor(ref local1);
          NumericLab1 calc = this.calc;
          MainFormLab1 mainFormLab1 = this;
          ref MainFormLab1 local2 = ref mainFormLab1;
          calc.Calculate(ref local2);
          MyUtils ut2 = this.ut;
          Form form2 = (Form) this;
          ref Form local3 = ref form2;
          ut2.RestoreCursor(ref local3);
          this.LoadKoeff();
          this.Koeff.Visible = true;
          ++this.istage;
          break;
        case 2:
          this.BtnStart.Text = "КОРНИ";
          this.LoadOtrezki();
          this.Otrezki.Visible = true;
          ++this.istage;
          break;
        case 3:
          this.BtnStart.Text = "ОТВЕТ";
          this.LoadKorni();
          this.Korni.Visible = true;
          ++this.istage;
          break;
        case 4:
          this.BtnStart.Text = "ЗАНОВО";
          this.TabOtveti.Visible = true;
          this.LoadOtvet();
          this.VariantNum.Enabled = true;
          this.ZadachaNum.Enabled = true;
          ++this.istage;
          break;
        default:
          this.ClearAllData();
          break;
      }
    }

    private void ClearAllBtn_Click(object sender, EventArgs e)
    {
      this.ClearAllData();
    }

    private void LoadUslovie()
    {
      this.InitParamNames();
      this.InitTaskData();
    }

    private void LoadKoeff()
    {
      int num = 1;
      do
      {
        this.Koeff.Items.Add((object) ("a" + (num - 1).ToString() + " = " + this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.Z, new object[1]
        {
          (object) num
        }, (string[]) null)))));
        ++num;
      }
      while (num <= 7);
    }

    private void LoadOtrezki()
    {
      int num = 1;
      int nk = this.calc.NK;
      for (int index = num; index <= nk; ++index)
        this.Otrezki.Items.Add((object) ("[ " + this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.V, new object[2]
        {
          (object) 1,
          (object) index
        }, (string[]) null))) + ", " + this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.V, new object[2]
        {
          (object) 2,
          (object) index
        }, (string[]) null))) + " ]"));
    }

    private void LoadKorni()
    {
      int num = 1;
      int nk = this.calc.NK;
      for (int index = num; index <= nk; ++index)
        this.Korni.Items.Add((object) ("x" + index.ToString() + " = " + this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.roots, new object[1]
        {
          (object) index
        }, (string[]) null)))));
    }

    private void LoadOtvet()
    {
      int num1 = 12;
      this.InitParamNames();
      int num2 = 1;
      int nk = this.calc.NK;
      for (int index = num2; index <= nk; ++index)
      {
        ListBox listBox = new ListBox();
        TabPage tabPage = new TabPage(Conversions.ToString(index));
        int num3 = 1;
        int num4 = num1;
        for (int paramNo = num3; paramNo <= num4; ++paramNo)
        {
          if (!(this.varNo == 2 & paramNo == 10))
            listBox.Items.Add((object) this.ParamNamesRes(paramNo, this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.solution, new object[2]
            {
              (object) index,
              (object) paramNo
            }, (string[]) null)))));
        }
        this.TabOtveti.Controls.Add((Control) tabPage);
        tabPage.Controls.Add((Control) listBox);
        listBox.Width = tabPage.Width;
        listBox.Height = tabPage.Height;
      }
    }

    public string ParamNames(int paramNo, string txt)
    {
      return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object) this.ParamName, new object[1]
      {
        (object) paramNo
      }, (string[]) null), (object) " = "), (object) txt), (object) " "), NewLateBinding.LateIndexGet((object) this.RazmerName, new object[1]
      {
        (object) paramNo
      }, (string[]) null)));
    }

    public string ParamNamesRes(int paramNo, string txt)
    {
      return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object) this.ParamNameRes, new object[1]
      {
        (object) paramNo
      }, (string[]) null), (object) " = "), (object) txt), (object) " "), NewLateBinding.LateIndexGet((object) this.RazmerNameRes, new object[1]
      {
        (object) paramNo
      }, (string[]) null)));
    }

    private void InitParamNames()
    {
      this.ParamName.SetValue((object) "G0", 1);
      this.ParamName.SetValue((object) "Ro0", 2);
      this.ParamName.SetValue((object) "U0", 3);
      this.ParamName.SetValue((object) "P0", 4);
      this.ParamName.SetValue((object) "G3", 5);
      this.ParamName.SetValue((object) "Ro3", 6);
      this.ParamName.SetValue((object) "U3", 7);
      this.ParamName.SetValue((object) "P3", 8);
      switch (this.varNo)
      {
        case 1:
          this.ParamNameRes.SetValue((object) "P2", 1);
          this.ParamNameRes.SetValue((object) "Ro2", 2);
          this.ParamNameRes.SetValue((object) "U2", 3);
          this.ParamNameRes.SetValue((object) "C2", 4);
          this.ParamNameRes.SetValue((object) "P3", 5);
          this.ParamNameRes.SetValue((object) "Ro3", 6);
          this.ParamNameRes.SetValue((object) "U3", 7);
          this.ParamNameRes.SetValue((object) "C3", 8);
          break;
        case 2:
          this.ParamNameRes.SetValue((object) "P3", 1);
          this.ParamNameRes.SetValue((object) "Ro3", 2);
          this.ParamNameRes.SetValue((object) "U3", 3);
          this.ParamNameRes.SetValue((object) "C3", 4);
          this.ParamNameRes.SetValue((object) "P2", 5);
          this.ParamNameRes.SetValue((object) "Ro2", 6);
          this.ParamNameRes.SetValue((object) "U2", 7);
          this.ParamNameRes.SetValue((object) "C2", 8);
          break;
        case 3:
        case 4:
          this.ParamNameRes.SetValue((object) "P2", 1);
          this.ParamNameRes.SetValue((object) "Ro2", 2);
          this.ParamNameRes.SetValue((object) "U2", 3);
          this.ParamNameRes.SetValue((object) "C2", 4);
          this.ParamNameRes.SetValue((object) "P1", 5);
          this.ParamNameRes.SetValue((object) "Ro1", 6);
          this.ParamNameRes.SetValue((object) "U1", 7);
          this.ParamNameRes.SetValue((object) "C1", 8);
          break;
      }
      this.ParamNameRes.SetValue((object) "D0", 9);
      this.ParamNameRes.SetValue((object) "D1", 10);
      this.ParamNameRes.SetValue((object) "Z0", 11);
      this.ParamNameRes.SetValue((object) "Z1", 12);
      this.RazmerName.SetValue((object) "", 1);
      this.RazmerName.SetValue((object) "г/см^3", 2);
      this.RazmerName.SetValue((object) "см/c", 3);
      this.RazmerName.SetValue((object) "дин/см^2", 4);
      this.RazmerName.SetValue((object) "", 5);
      this.RazmerName.SetValue((object) "г/см^3", 6);
      this.RazmerName.SetValue((object) "см/c", 7);
      this.RazmerName.SetValue((object) "дин/см^2", 8);
      this.RazmerNameRes.SetValue((object) "дин/см^2", 1);
      this.RazmerNameRes.SetValue((object) "г/см^3", 2);
      this.RazmerNameRes.SetValue((object) "см/c", 3);
      this.RazmerNameRes.SetValue((object) "см/c", 4);
      this.RazmerNameRes.SetValue((object) "дин/см^2", 5);
      this.RazmerNameRes.SetValue((object) "г/см^3", 6);
      this.RazmerNameRes.SetValue((object) "см/c", 7);
      this.RazmerNameRes.SetValue((object) "см/c", 8);
      this.RazmerNameRes.SetValue((object) "см/c", 9);
      this.RazmerNameRes.SetValue((object) "см/c", 10);
      this.RazmerNameRes.SetValue((object) "", 11);
      this.RazmerNameRes.SetValue((object) "", 12);
      if (this.varNo == 2)
      {
        this.ParamName.SetValue((object) "P0", 3);
        this.ParamName.SetValue((object) "U0", 4);
        this.ParamName.SetValue((object) "C3", 6);
        this.ParamName.SetValue((object) "P3", 7);
        this.ParamName.SetValue((object) "U3", 8);
        this.RazmerName.SetValue((object) "дин/см^2", 3);
        this.RazmerName.SetValue((object) "см/c", 4);
        this.RazmerName.SetValue((object) "см/c", 6);
        this.RazmerName.SetValue((object) "дин/см^2", 7);
        this.RazmerName.SetValue((object) "см/c", 8);
      }
      if (this.varNo <= 2)
        return;
      this.ParamName.SetValue((object) "C0", 5);
      this.ParamName.SetValue((object) "G3", 6);
      this.ParamName.SetValue((object) "Ro3", 7);
      this.ParamName.SetValue((object) "U3", 8);
      this.ParamName.SetValue((object) "P3", 9);
      this.ParamName.SetValue((object) "C3", 10);
      this.RazmerName.SetValue((object) "см/с", 5);
      this.RazmerName.SetValue((object) "", 6);
      this.RazmerName.SetValue((object) "г/см^3", 7);
      this.RazmerName.SetValue((object) "см/c", 8);
      this.RazmerName.SetValue((object) "дин/см^2", 9);
      this.RazmerName.SetValue((object) "см/с", 10);
    }

    private void ClearAllData()
    {
      this.istage = (byte) 0;
      this.BtnStart.Text = "СТАРТ";
      this.Uslovie.Visible = false;
      this.Koeff.Visible = false;
      this.Otrezki.Visible = false;
      this.Korni.Visible = false;
      this.TabOtveti.Visible = false;
      this.VariantNum.Enabled = true;
      this.ZadachaNum.Enabled = true;
      this.Uslovie.Items.Clear();
      this.Koeff.Items.Clear();
      this.Otrezki.Items.Clear();
      this.Korni.Items.Clear();
      this.TabOtveti.Controls.Clear();
    }

    private void InitTaskData()
    {
      int num1;
      double[] numArray1;
      double[] numArray2;
      switch (this.varNo)
      {
        case 1:
          num1 = 8;
          switch (this.taskNo)
          {
            case 1:
              MyUtils ut1 = this.ut;
              Array array1 = (Array) numArray1;
              ref Array local1 = ref array1;
              double x1_1 = 1.66666667;
              double x2_1 = 0.0002219;
              double x3_1 = -158700.0;
              double x4_1 = 3781200.0;
              double x5_1 = 1.66666667;
              double x6_1 = 0.00271;
              double x7_1 = 10.0;
              double x8_1 = 500000.0;
              ut1.FillArray(ref local1, x1_1, x2_1, x3_1, x4_1, x5_1, x6_1, x7_1, x8_1);
              numArray2 = (double[]) array1;
              break;
            case 2:
              MyUtils ut2 = this.ut;
              Array array2 = (Array) numArray1;
              ref Array local2 = ref array2;
              double x1_2 = 1.66666667;
              double x2_2 = 7.9;
              double x3_2 = 0.0;
              double x4_2 = 3040000000.0;
              double x5_2 = 1.66666667;
              double x6_2 = 11.37;
              double x7_2 = 50000.0;
              double x8_2 = 1179280000.0;
              ut2.FillArray(ref local2, x1_2, x2_2, x3_2, x4_2, x5_2, x6_2, x7_2, x8_2);
              numArray2 = (double[]) array2;
              break;
            case 3:
              MyUtils ut3 = this.ut;
              Array array3 = (Array) numArray1;
              ref Array local3 = ref array3;
              double x1_3 = 1.66666667;
              double x2_3 = 0.00271;
              double x3_3 = 0.0;
              double x4_3 = 500000.0;
              double x5_3 = 1.4;
              double x6_3 = 0.0002219;
              double x7_3 = 158700.0;
              double x8_3 = 1000000.0;
              ut3.FillArray(ref local3, x1_3, x2_3, x3_3, x4_3, x5_3, x6_3, x7_3, x8_3);
              numArray2 = (double[]) array3;
              break;
            case 4:
              MyUtils ut4 = this.ut;
              Array array4 = (Array) numArray1;
              ref Array local4 = ref array4;
              double x1_4 = 1.66666667;
              double x2_4 = 7.9;
              double x3_4 = 0.0;
              double x4_4 = 3040000000.0;
              double x5_4 = 1.4;
              double x6_4 = 11.37;
              double x7_4 = 50000.0;
              double x8_4 = 1179280000.0;
              ut4.FillArray(ref local4, x1_4, x2_4, x3_4, x4_4, x5_4, x6_4, x7_4, x8_4);
              numArray2 = (double[]) array4;
              break;
            case 5:
              MyUtils ut5 = this.ut;
              Array array5 = (Array) numArray1;
              ref Array local5 = ref array5;
              double x1_5 = 1.4;
              double x2_5 = 7.9;
              double x3_5 = 0.0;
              double x4_5 = 3040000000.0;
              double x5_5 = 1.4;
              double x6_5 = 11.37;
              double x7_5 = 50000.0;
              double x8_5 = 1179280000.0;
              ut5.FillArray(ref local5, x1_5, x2_5, x3_5, x4_5, x5_5, x6_5, x7_5, x8_5);
              numArray2 = (double[]) array5;
              break;
            case 6:
              MyUtils ut6 = this.ut;
              Array array6 = (Array) numArray1;
              ref Array local6 = ref array6;
              double x1_6 = 1.66666667;
              double x2_6 = 11.37;
              double x3_6 = -22800.0;
              double x4_6 = 1179280000.0;
              double x5_6 = 1.66666667;
              double x6_6 = 7.9;
              double x7_6 = 27200.0;
              double x8_6 = 3040000000.0;
              ut6.FillArray(ref local6, x1_6, x2_6, x3_6, x4_6, x5_6, x6_6, x7_6, x8_6);
              numArray2 = (double[]) array6;
              break;
            case 7:
              MyUtils ut7 = this.ut;
              Array array7 = (Array) numArray1;
              ref Array local7 = ref array7;
              double x1_7 = 1.66666667;
              double x2_7 = 7.9;
              double x3_7 = -27200.0;
              double x4_7 = 3040000000.0;
              double x5_7 = 1.4;
              double x6_7 = 11.37;
              double x7_7 = 22800.0;
              double x8_7 = 1179280000.0;
              ut7.FillArray(ref local7, x1_7, x2_7, x3_7, x4_7, x5_7, x6_7, x7_7, x8_7);
              numArray2 = (double[]) array7;
              break;
            case 8:
              MyUtils ut8 = this.ut;
              Array array8 = (Array) numArray1;
              ref Array local8 = ref array8;
              double x1_8 = 1.4;
              double x2_8 = 11.37;
              double x3_8 = -22800.0;
              double x4_8 = 1179280000.0;
              double x5_8 = 1.4;
              double x6_8 = 7.9;
              double x7_8 = 27200.0;
              double x8_8 = 3040000000.0;
              ut8.FillArray(ref local8, x1_8, x2_8, x3_8, x4_8, x5_8, x6_8, x7_8, x8_8);
              numArray2 = (double[]) array8;
              break;
          }
        case 2:
          num1 = 8;
          switch (this.taskNo)
          {
            case 1:
              MyUtils ut9 = this.ut;
              Array array9 = (Array) numArray1;
              ref Array local9 = ref array9;
              double x1_9 = 1.66666667;
              double x2_9 = 0.0001694;
              double x3_9 = 1013000.0;
              double x4_9 = 0.0;
              double x5_9 = 1.4;
              double x6_9 = 36537.0;
              double x7_9 = 1676800.0;
              double x8_9 = 0.0;
              ut9.FillArray(ref local9, x1_9, x2_9, x3_9, x4_9, x5_9, x6_9, x7_9, x8_9);
              numArray2 = (double[]) array9;
              break;
            case 2:
              MyUtils ut10 = this.ut;
              Array array10 = (Array) numArray1;
              ref Array local10 = ref array10;
              double x1_10 = 1.66666667;
              double x2_10 = 0.0001694;
              double x3_10 = 1013000.0;
              double x4_10 = 0.0;
              double x5_10 = 1.4;
              double x6_10 = 36537.0;
              double x7_10 = 1676800.0;
              double x8_10 = 12290.0;
              ut10.FillArray(ref local10, x1_10, x2_10, x3_10, x4_10, x5_10, x6_10, x7_10, x8_10);
              numArray2 = (double[]) array10;
              break;
            case 3:
              MyUtils ut11 = this.ut;
              Array array11 = (Array) numArray1;
              ref Array local11 = ref array11;
              double x1_11 = 1.66666667;
              double x2_11 = 1E-05;
              double x3_11 = 3848.0;
              double x4_11 = 0.0;
              double x5_11 = 1.66666667;
              double x6_11 = 13147.8;
              double x7_11 = 1179280000.0;
              double x8_11 = 50000.0;
              ut11.FillArray(ref local11, x1_11, x2_11, x3_11, x4_11, x5_11, x6_11, x7_11, x8_11);
              numArray2 = (double[]) array11;
              break;
            case 4:
              MyUtils ut12 = this.ut;
              Array array12 = (Array) numArray1;
              ref Array local12 = ref array12;
              double x1_12 = 1.4;
              double x2_12 = 0.0001694;
              double x3_12 = 1013000.0;
              double x4_12 = 0.001;
              double x5_12 = 1.4;
              double x6_12 = 36537.0;
              double x7_12 = 1676800.0;
              double x8_12 = 12290.0;
              ut12.FillArray(ref local12, x1_12, x2_12, x3_12, x4_12, x5_12, x6_12, x7_12, x8_12);
              numArray2 = (double[]) array12;
              break;
            case 5:
              MyUtils ut13 = this.ut;
              Array array13 = (Array) numArray1;
              ref Array local13 = ref array13;
              double x1_13 = 1.4;
              double x2_13 = 1E-05;
              double x3_13 = 3848.0;
              double x4_13 = 0.0;
              double x5_13 = 1.66666667;
              double x6_13 = 13147.8;
              double x7_13 = 1179280000.0;
              double x8_13 = 50000.0;
              ut13.FillArray(ref local13, x1_13, x2_13, x3_13, x4_13, x5_13, x6_13, x7_13, x8_13);
              numArray2 = (double[]) array13;
              break;
            case 6:
              MyUtils ut14 = this.ut;
              Array array14 = (Array) numArray1;
              ref Array local14 = ref array14;
              double x1_14 = 1.66666667;
              double x2_14 = 0.0001694;
              double x3_14 = 1013000.0;
              double x4_14 = -0.1;
              double x5_14 = 1.66666667;
              double x6_14 = 36537.0;
              double x7_14 = 1676800.0;
              double x8_14 = 0.0;
              ut14.FillArray(ref local14, x1_14, x2_14, x3_14, x4_14, x5_14, x6_14, x7_14, x8_14);
              numArray2 = (double[]) array14;
              break;
            case 7:
              MyUtils ut15 = this.ut;
              Array array15 = (Array) numArray1;
              ref Array local15 = ref array15;
              double x1_15 = 1.66666667;
              double x2_15 = 1E-05;
              double x3_15 = 3848.0;
              double x4_15 = 0.0;
              double x5_15 = 1.66666667;
              double x6_15 = 25324.8;
              double x7_15 = 3040000000.0;
              double x8_15 = 0.0;
              ut15.FillArray(ref local15, x1_15, x2_15, x3_15, x4_15, x5_15, x6_15, x7_15, x8_15);
              numArray2 = (double[]) array15;
              break;
            case 8:
              MyUtils ut16 = this.ut;
              Array array16 = (Array) numArray1;
              ref Array local16 = ref array16;
              double x1_16 = 1.66666667;
              double x2_16 = 1E-05;
              double x3_16 = 3848.0;
              double x4_16 = 0.0;
              double x5_16 = 1.4;
              double x6_16 = 25324.8;
              double x7_16 = 3040000000.0;
              double x8_16 = 0.0;
              ut16.FillArray(ref local16, x1_16, x2_16, x3_16, x4_16, x5_16, x6_16, x7_16, x8_16);
              numArray2 = (double[]) array16;
              break;
          }
        case 3:
          num1 = 10;
          switch (this.taskNo)
          {
            case 1:
              MyUtils ut17 = this.ut;
              Array array17 = (Array) numArray1;
              ref Array local17 = ref array17;
              double x1_17 = 3.0;
              double x2_17 = 13.76163;
              double x3_17 = -532238.9;
              double x4_17 = 5176613000000.0;
              double x5_17 = 465000.0;
              double x6_17 = 3.0;
              double x7_17 = 100.0;
              double x8_17 = 0.0;
              double x9_1 = 0.0;
              double x10_1 = 465000.0;
              ut17.FillArray(ref local17, x1_17, x2_17, x3_17, x4_17, x5_17, x6_17, x7_17, x8_17, x9_1, x10_1);
              numArray2 = (double[]) array17;
              break;
            case 2:
              MyUtils ut18 = this.ut;
              Array array18 = (Array) numArray1;
              ref Array local18 = ref array18;
              double x1_18 = 3.0;
              double x2_18 = 100.0;
              double x3_18 = -1000000.0;
              double x4_18 = 0.0;
              double x5_18 = 197200.0;
              double x6_18 = 3.0;
              double x7_18 = 21.80089;
              double x8_18 = -532238.9;
              double x9_2 = 5176613000000.0;
              double x10_2 = 197200.0;
              ut18.FillArray(ref local18, x1_18, x2_18, x3_18, x4_18, x5_18, x6_18, x7_18, x8_18, x9_2, x10_2);
              numArray2 = (double[]) array18;
              break;
            case 3:
              MyUtils ut19 = this.ut;
              Array array19 = (Array) numArray1;
              ref Array local19 = ref array19;
              double x1_19 = 3.0;
              double x2_19 = 13.76163;
              double x3_19 = 0.0;
              double x4_19 = 5176613000000.0;
              double x5_19 = 465000.0;
              double x6_19 = 3.0;
              double x7_19 = 100.0;
              double x8_19 = 532238.9;
              double x9_3 = 0.0;
              double x10_3 = 465000.0;
              ut19.FillArray(ref local19, x1_19, x2_19, x3_19, x4_19, x5_19, x6_19, x7_19, x8_19, x9_3, x10_3);
              numArray2 = (double[]) array19;
              break;
            case 4:
              MyUtils ut20 = this.ut;
              Array array20 = (Array) numArray1;
              ref Array local20 = ref array20;
              double x1_20 = 3.0;
              double x2_20 = 100.0;
              double x3_20 = -467761.1;
              double x4_20 = 0.0;
              double x5_20 = 197200.0;
              double x6_20 = 3.0;
              double x7_20 = 21.80089;
              double x8_20 = 0.0;
              double x9_4 = 5176613000000.0;
              double x10_4 = 197200.0;
              ut20.FillArray(ref local20, x1_20, x2_20, x3_20, x4_20, x5_20, x6_20, x7_20, x8_20, x9_4, x10_4);
              numArray2 = (double[]) array20;
              break;
            case 5:
              MyUtils ut21 = this.ut;
              Array array21 = (Array) numArray1;
              ref Array local21 = ref array21;
              double x1_21 = 3.0;
              double x2_21 = 100.0;
              double x3_21 = 0.0;
              double x4_21 = 0.0;
              double x5_21 = 465000.0;
              double x6_21 = 3.0;
              double x7_21 = 13.76163;
              double x8_21 = 532238.9;
              double x9_5 = 5176613000000.0;
              double x10_5 = 465000.0;
              ut21.FillArray(ref local21, x1_21, x2_21, x3_21, x4_21, x5_21, x6_21, x7_21, x8_21, x9_5, x10_5);
              numArray2 = (double[]) array21;
              break;
            case 6:
              MyUtils ut22 = this.ut;
              Array array22 = (Array) numArray1;
              ref Array local22 = ref array22;
              double x1_22 = 3.0;
              double x2_22 = 21.80089;
              double x3_22 = 532238.9;
              double x4_22 = 5176613000000.0;
              double x5_22 = 197200.0;
              double x6_22 = 3.0;
              double x7_22 = 100.0;
              double x8_22 = 1000000.0;
              double x9_6 = 0.0;
              double x10_6 = 197200.0;
              ut22.FillArray(ref local22, x1_22, x2_22, x3_22, x4_22, x5_22, x6_22, x7_22, x8_22, x9_6, x10_6);
              numArray2 = (double[]) array22;
              break;
            case 7:
              MyUtils ut23 = this.ut;
              Array array23 = (Array) numArray1;
              ref Array local23 = ref array23;
              double x1_23 = 3.0;
              double x2_23 = 100.0;
              double x3_23 = -532238.9;
              double x4_23 = 0.0;
              double x5_23 = 465000.0;
              double x6_23 = 3.0;
              double x7_23 = 13.76163;
              double x8_23 = 0.0;
              double x9_7 = 5176613000000.0;
              double x10_7 = 465000.0;
              ut23.FillArray(ref local23, x1_23, x2_23, x3_23, x4_23, x5_23, x6_23, x7_23, x8_23, x9_7, x10_7);
              numArray2 = (double[]) array23;
              break;
            case 8:
              MyUtils ut24 = this.ut;
              Array array24 = (Array) numArray1;
              ref Array local24 = ref array24;
              double x1_24 = 3.0;
              double x2_24 = 21.80089;
              double x3_24 = 0.0;
              double x4_24 = 5176613000000.0;
              double x5_24 = 197200.0;
              double x6_24 = 3.0;
              double x7_24 = 100.0;
              double x8_24 = 467761.1;
              double x9_8 = 0.0;
              double x10_8 = 197200.0;
              ut24.FillArray(ref local24, x1_24, x2_24, x3_24, x4_24, x5_24, x6_24, x7_24, x8_24, x9_8, x10_8);
              numArray2 = (double[]) array24;
              break;
          }
        case 4:
          num1 = 10;
          switch (this.taskNo)
          {
            case 1:
              MyUtils ut25 = this.ut;
              Array array25 = (Array) numArray1;
              ref Array local25 = ref array25;
              double x1_25 = 3.0;
              double x2_25 = 11.346;
              double x3_25 = 1000000.0;
              double x4_25 = 0.0;
              double x5_25 = 197200.0;
              double x6_25 = 3.0;
              double x7_25 = 7.85;
              double x8_25 = 0.0;
              double x9_9 = 0.0;
              double x10_9 = 465000.0;
              ut25.FillArray(ref local25, x1_25, x2_25, x3_25, x4_25, x5_25, x6_25, x7_25, x8_25, x9_9, x10_9);
              numArray2 = (double[]) array25;
              break;
            case 2:
              MyUtils ut26 = this.ut;
              Array array26 = (Array) numArray1;
              ref Array local26 = ref array26;
              double x1_26 = 3.0;
              double x2_26 = 11.346;
              double x3_26 = -467761.1;
              double x4_26 = 0.0;
              double x5_26 = 197200.0;
              double x6_26 = 3.0;
              double x7_26 = 7.85;
              double x8_26 = 532238.9;
              double x9_10 = 0.0;
              double x10_10 = 465000.0;
              ut26.FillArray(ref local26, x1_26, x2_26, x3_26, x4_26, x5_26, x6_26, x7_26, x8_26, x9_10, x10_10);
              numArray2 = (double[]) array26;
              break;
            case 3:
              MyUtils ut27 = this.ut;
              Array array27 = (Array) numArray1;
              ref Array local27 = ref array27;
              double x1_27 = 3.0;
              double x2_27 = 7.85;
              double x3_27 = 0.0;
              double x4_27 = 0.0;
              double x5_27 = 465000.0;
              double x6_27 = 3.0;
              double x7_27 = 11.346;
              double x8_27 = 1000000.0;
              double x9_11 = 0.0;
              double x10_11 = 197200.0;
              ut27.FillArray(ref local27, x1_27, x2_27, x3_27, x4_27, x5_27, x6_27, x7_27, x8_27, x9_11, x10_11);
              numArray2 = (double[]) array27;
              break;
            case 4:
              MyUtils ut28 = this.ut;
              Array array28 = (Array) numArray1;
              ref Array local28 = ref array28;
              double x1_28 = 3.0;
              double x2_28 = 7.85;
              double x3_28 = -532238.9;
              double x4_28 = 0.0;
              double x5_28 = 465000.0;
              double x6_28 = 3.0;
              double x7_28 = 11.346;
              double x8_28 = 467761.1;
              double x9_12 = 0.0;
              double x10_12 = 197200.0;
              ut28.FillArray(ref local28, x1_28, x2_28, x3_28, x4_28, x5_28, x6_28, x7_28, x8_28, x9_12, x10_12);
              numArray2 = (double[]) array28;
              break;
            case 5:
              MyUtils ut29 = this.ut;
              Array array29 = (Array) numArray1;
              ref Array local29 = ref array29;
              double x1_29 = 3.0;
              double x2_29 = 7.85;
              double x3_29 = -1000000.0;
              double x4_29 = 0.0;
              double x5_29 = 465000.0;
              double x6_29 = 3.0;
              double x7_29 = 11.346;
              double x8_29 = 0.0;
              double x9_13 = 0.0;
              double x10_13 = 197200.0;
              ut29.FillArray(ref local29, x1_29, x2_29, x3_29, x4_29, x5_29, x6_29, x7_29, x8_29, x9_13, x10_13);
              numArray2 = (double[]) array29;
              break;
            case 6:
              MyUtils ut30 = this.ut;
              Array array30 = (Array) numArray1;
              ref Array local30 = ref array30;
              double x1_30 = 3.0;
              double x2_30 = 11.346;
              double x3_30 = 0.0;
              double x4_30 = 0.0;
              double x5_30 = 197200.0;
              double x6_30 = 3.0;
              double x7_30 = 7.85;
              double x8_30 = 1000000.0;
              double x9_14 = 0.0;
              double x10_14 = 465000.0;
              ut30.FillArray(ref local30, x1_30, x2_30, x3_30, x4_30, x5_30, x6_30, x7_30, x8_30, x9_14, x10_14);
              numArray2 = (double[]) array30;
              break;
            case 7:
              MyUtils ut31 = this.ut;
              Array array31 = (Array) numArray1;
              ref Array local31 = ref array31;
              double x1_31 = 3.0;
              double x2_31 = 7.85;
              double x3_31 = 532238.9;
              double x4_31 = 0.0;
              double x5_31 = 465000.0;
              double x6_31 = 3.0;
              double x7_31 = 11.346;
              double x8_31 = -467761.1;
              double x9_15 = 0.0;
              double x10_15 = 197200.0;
              ut31.FillArray(ref local31, x1_31, x2_31, x3_31, x4_31, x5_31, x6_31, x7_31, x8_31, x9_15, x10_15);
              numArray2 = (double[]) array31;
              break;
            case 8:
              MyUtils ut32 = this.ut;
              Array array32 = (Array) numArray1;
              ref Array local32 = ref array32;
              double x1_32 = 3.0;
              double x2_32 = 11.346;
              double x3_32 = 467761.1;
              double x4_32 = 0.0;
              double x5_32 = 1972.0;
              double x6_32 = 3.0;
              double x7_32 = 7.85;
              double x8_32 = -532238.9;
              double x9_16 = 0.0;
              double x10_16 = 4650.0;
              ut32.FillArray(ref local32, x1_32, x2_32, x3_32, x4_32, x5_32, x6_32, x7_32, x8_32, x9_16, x10_16);
              numArray2 = (double[]) array32;
              break;
          }
      }
      int num2 = 0;
      int num3 = num1 - 1;
      for (int index = num2; index <= num3; ++index)
      {
        this.Uslovie.Items.Add((object) this.ParamNames(index + 1, this.ut.MyDblToStr(numArray2[index])));
        NumericLab1 calc = this.calc;
        int paramNo = index + 1;
        string str = this.ut.MyDblToStr(numArray2[index]);
        MainFormLab1 mainFormLab1 = this;
        ref MainFormLab1 local33 = ref mainFormLab1;
        calc.InitParam(paramNo, str, ref local33);
      }
    }

    private void BtnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void VariantNum_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyValue != 13)
        return;
      this.BtnStart.PerformClick();
    }

    private void ZadachaNum_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyValue != 13)
        return;
      this.BtnStart.PerformClick();
    }

    private void MainFormLab1_FormClosed(object sender, FormClosedEventArgs e)
    {
      MyProject.Forms.Proverka.Show();
    }
  }
}
