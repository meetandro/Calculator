namespace CalculatorApp;

partial class CalculatorApp
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        ZeroButton = new Button();
        OneButton = new Button();
        TwoButton = new Button();
        ThreeButton = new Button();
        FourButton = new Button();
        FiveButton = new Button();
        SixButton = new Button();
        SevenButton = new Button();
        EightButton = new Button();
        NineButton = new Button();
        AddButton = new Button();
        SubtractButton = new Button();
        MultiplyButton = new Button();
        DivideButton = new Button();
        EqualsButton = new Button();
        ClearButton = new Button();
        CalculatorGroupBox = new GroupBox();
        InputPanel = new Panel();
        ExpressionLabel = new Label();
        ResultLabel = new Label();
        CalculatorGroupBox.SuspendLayout();
        InputPanel.SuspendLayout();
        SuspendLayout();
        // 
        // ZeroButton
        // 
        ZeroButton.BackColor = SystemColors.Control;
        ZeroButton.FlatStyle = FlatStyle.Flat;
        ZeroButton.Font = new Font("MS Reference Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ZeroButton.Location = new Point(118, 371);
        ZeroButton.Name = "ZeroButton";
        ZeroButton.Size = new Size(61, 59);
        ZeroButton.TabIndex = 8;
        ZeroButton.Text = "0";
        ZeroButton.UseVisualStyleBackColor = false;
        ZeroButton.Click += DigitButton_Click;
        // 
        // OneButton
        // 
        OneButton.BackColor = SystemColors.Control;
        OneButton.FlatStyle = FlatStyle.Flat;
        OneButton.Font = new Font("MS Reference Sans Serif", 19.8000011F);
        OneButton.Location = new Point(26, 289);
        OneButton.Name = "OneButton";
        OneButton.Size = new Size(61, 59);
        OneButton.TabIndex = 15;
        OneButton.Text = "1";
        OneButton.UseVisualStyleBackColor = false;
        OneButton.Click += DigitButton_Click;
        // 
        // TwoButton
        // 
        TwoButton.BackColor = SystemColors.Control;
        TwoButton.FlatStyle = FlatStyle.Flat;
        TwoButton.Font = new Font("MS Reference Sans Serif", 19.8000011F);
        TwoButton.Location = new Point(118, 289);
        TwoButton.Name = "TwoButton";
        TwoButton.Size = new Size(61, 59);
        TwoButton.TabIndex = 16;
        TwoButton.Text = "2";
        TwoButton.UseVisualStyleBackColor = false;
        TwoButton.Click += DigitButton_Click;
        // 
        // ThreeButton
        // 
        ThreeButton.BackColor = SystemColors.Control;
        ThreeButton.FlatStyle = FlatStyle.Flat;
        ThreeButton.Font = new Font("MS Reference Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ThreeButton.Location = new Point(216, 289);
        ThreeButton.Name = "ThreeButton";
        ThreeButton.Size = new Size(61, 59);
        ThreeButton.TabIndex = 17;
        ThreeButton.Text = "3";
        ThreeButton.UseVisualStyleBackColor = false;
        ThreeButton.Click += DigitButton_Click;
        // 
        // FourButton
        // 
        FourButton.BackColor = SystemColors.Control;
        FourButton.FlatStyle = FlatStyle.Flat;
        FourButton.Font = new Font("MS Reference Sans Serif", 19.8000011F);
        FourButton.Location = new Point(26, 202);
        FourButton.Name = "FourButton";
        FourButton.Size = new Size(61, 59);
        FourButton.TabIndex = 5;
        FourButton.Text = "4";
        FourButton.UseVisualStyleBackColor = false;
        FourButton.Click += DigitButton_Click;
        // 
        // FiveButton
        // 
        FiveButton.BackColor = SystemColors.Control;
        FiveButton.FlatStyle = FlatStyle.Flat;
        FiveButton.Font = new Font("MS Reference Sans Serif", 19.8000011F);
        FiveButton.Location = new Point(118, 202);
        FiveButton.Name = "FiveButton";
        FiveButton.Size = new Size(61, 59);
        FiveButton.TabIndex = 6;
        FiveButton.Text = "5";
        FiveButton.UseVisualStyleBackColor = false;
        FiveButton.Click += DigitButton_Click;
        // 
        // SixButton
        // 
        SixButton.BackColor = SystemColors.Control;
        SixButton.FlatStyle = FlatStyle.Flat;
        SixButton.Font = new Font("MS Reference Sans Serif", 19.8000011F);
        SixButton.Location = new Point(216, 202);
        SixButton.Name = "SixButton";
        SixButton.Size = new Size(61, 59);
        SixButton.TabIndex = 7;
        SixButton.Text = "6";
        SixButton.UseVisualStyleBackColor = false;
        SixButton.Click += DigitButton_Click;
        // 
        // SevenButton
        // 
        SevenButton.BackColor = SystemColors.Control;
        SevenButton.FlatStyle = FlatStyle.Flat;
        SevenButton.Font = new Font("MS Reference Sans Serif", 19.8000011F);
        SevenButton.Location = new Point(26, 120);
        SevenButton.Name = "SevenButton";
        SevenButton.Size = new Size(61, 59);
        SevenButton.TabIndex = 2;
        SevenButton.Text = "7";
        SevenButton.UseVisualStyleBackColor = false;
        SevenButton.Click += DigitButton_Click;
        // 
        // EightButton
        // 
        EightButton.BackColor = SystemColors.Control;
        EightButton.FlatStyle = FlatStyle.Flat;
        EightButton.Font = new Font("MS Reference Sans Serif", 19.8000011F);
        EightButton.Location = new Point(118, 120);
        EightButton.Name = "EightButton";
        EightButton.Size = new Size(61, 59);
        EightButton.TabIndex = 3;
        EightButton.Text = "8";
        EightButton.UseVisualStyleBackColor = false;
        EightButton.Click += DigitButton_Click;
        // 
        // NineButton
        // 
        NineButton.BackColor = SystemColors.Control;
        NineButton.FlatStyle = FlatStyle.Flat;
        NineButton.Font = new Font("MS Reference Sans Serif", 19.8000011F);
        NineButton.Location = new Point(216, 120);
        NineButton.Name = "NineButton";
        NineButton.Size = new Size(61, 59);
        NineButton.TabIndex = 4;
        NineButton.Text = "9";
        NineButton.UseVisualStyleBackColor = false;
        NineButton.Click += DigitButton_Click;
        // 
        // AddButton
        // 
        AddButton.BackColor = SystemColors.ControlDarkDark;
        AddButton.FlatStyle = FlatStyle.Flat;
        AddButton.Font = new Font("MS Reference Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
        AddButton.ForeColor = SystemColors.Control;
        AddButton.Location = new Point(314, 120);
        AddButton.Name = "AddButton";
        AddButton.Size = new Size(61, 59);
        AddButton.TabIndex = 10;
        AddButton.Text = "+";
        AddButton.UseVisualStyleBackColor = false;
        AddButton.Click += OperationButton_Click;
        // 
        // SubtractButton
        // 
        SubtractButton.BackColor = SystemColors.ControlDarkDark;
        SubtractButton.FlatStyle = FlatStyle.Flat;
        SubtractButton.Font = new Font("MS Reference Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
        SubtractButton.ForeColor = SystemColors.Control;
        SubtractButton.Location = new Point(314, 202);
        SubtractButton.Name = "SubtractButton";
        SubtractButton.Size = new Size(61, 59);
        SubtractButton.TabIndex = 11;
        SubtractButton.Text = "-";
        SubtractButton.UseVisualStyleBackColor = false;
        SubtractButton.Click += OperationButton_Click;
        // 
        // MultiplyButton
        // 
        MultiplyButton.BackColor = SystemColors.ControlDarkDark;
        MultiplyButton.FlatStyle = FlatStyle.Flat;
        MultiplyButton.Font = new Font("MS Reference Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
        MultiplyButton.ForeColor = SystemColors.Control;
        MultiplyButton.Location = new Point(314, 289);
        MultiplyButton.Name = "MultiplyButton";
        MultiplyButton.Size = new Size(61, 59);
        MultiplyButton.TabIndex = 12;
        MultiplyButton.Text = "X";
        MultiplyButton.UseVisualStyleBackColor = false;
        MultiplyButton.Click += OperationButton_Click;
        // 
        // DivideButton
        // 
        DivideButton.BackColor = SystemColors.ControlDarkDark;
        DivideButton.FlatStyle = FlatStyle.Flat;
        DivideButton.Font = new Font("MS Reference Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
        DivideButton.ForeColor = SystemColors.Control;
        DivideButton.Location = new Point(314, 371);
        DivideButton.Name = "DivideButton";
        DivideButton.Size = new Size(61, 59);
        DivideButton.TabIndex = 13;
        DivideButton.Text = "/";
        DivideButton.UseVisualStyleBackColor = false;
        DivideButton.Click += OperationButton_Click;
        // 
        // EqualsButton
        // 
        EqualsButton.BackColor = SystemColors.ControlDarkDark;
        EqualsButton.FlatStyle = FlatStyle.Flat;
        EqualsButton.Font = new Font("MS Reference Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
        EqualsButton.ForeColor = SystemColors.Control;
        EqualsButton.Location = new Point(216, 371);
        EqualsButton.Name = "EqualsButton";
        EqualsButton.Size = new Size(61, 59);
        EqualsButton.TabIndex = 9;
        EqualsButton.Text = "=";
        EqualsButton.UseVisualStyleBackColor = false;
        EqualsButton.Click += EqualsButton_Click;
        // 
        // ClearButton
        // 
        ClearButton.BackColor = Color.Brown;
        ClearButton.FlatStyle = FlatStyle.Flat;
        ClearButton.Font = new Font("MS Reference Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ClearButton.ForeColor = SystemColors.Control;
        ClearButton.Location = new Point(26, 371);
        ClearButton.Name = "ClearButton";
        ClearButton.Size = new Size(61, 59);
        ClearButton.TabIndex = 14;
        ClearButton.Text = "C";
        ClearButton.UseVisualStyleBackColor = false;
        ClearButton.Click += ClearButton_Click;
        // 
        // CalculatorGroupBox
        // 
        CalculatorGroupBox.BackColor = SystemColors.ScrollBar;
        CalculatorGroupBox.Controls.Add(InputPanel);
        CalculatorGroupBox.Controls.Add(ZeroButton);
        CalculatorGroupBox.Controls.Add(OneButton);
        CalculatorGroupBox.Controls.Add(TwoButton);
        CalculatorGroupBox.Controls.Add(ThreeButton);
        CalculatorGroupBox.Controls.Add(FourButton);
        CalculatorGroupBox.Controls.Add(FiveButton);
        CalculatorGroupBox.Controls.Add(SixButton);
        CalculatorGroupBox.Controls.Add(SevenButton);
        CalculatorGroupBox.Controls.Add(EightButton);
        CalculatorGroupBox.Controls.Add(NineButton);
        CalculatorGroupBox.Controls.Add(AddButton);
        CalculatorGroupBox.Controls.Add(SubtractButton);
        CalculatorGroupBox.Controls.Add(MultiplyButton);
        CalculatorGroupBox.Controls.Add(DivideButton);
        CalculatorGroupBox.Controls.Add(EqualsButton);
        CalculatorGroupBox.Controls.Add(ClearButton);
        CalculatorGroupBox.Font = new Font("MT Extra", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
        CalculatorGroupBox.Location = new Point(169, -9);
        CalculatorGroupBox.Name = "CalculatorGroupBox";
        CalculatorGroupBox.Size = new Size(401, 447);
        CalculatorGroupBox.TabIndex = 18;
        CalculatorGroupBox.TabStop = false;
        // 
        // InputPanel
        // 
        InputPanel.BackColor = SystemColors.ActiveBorder;
        InputPanel.Controls.Add(ExpressionLabel);
        InputPanel.Controls.Add(ResultLabel);
        InputPanel.Location = new Point(26, 24);
        InputPanel.Name = "InputPanel";
        InputPanel.Size = new Size(349, 80);
        InputPanel.TabIndex = 0;
        // 
        // ExpressionLabel
        // 
        ExpressionLabel.AutoSize = true;
        ExpressionLabel.Font = new Font("MS Reference Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ExpressionLabel.Location = new Point(8, 10);
        ExpressionLabel.Name = "ExpressionLabel";
        ExpressionLabel.Size = new Size(0, 23);
        ExpressionLabel.TabIndex = 1;
        // 
        // ResultLabel
        // 
        ResultLabel.AutoSize = true;
        ResultLabel.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ResultLabel.Location = new Point(8, 41);
        ResultLabel.Name = "ResultLabel";
        ResultLabel.Size = new Size(0, 28);
        ResultLabel.TabIndex = 0;
        // 
        // CalculatorApp
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(CalculatorGroupBox);
        Name = "CalculatorApp";
        Text = "Calculator";
        CalculatorGroupBox.ResumeLayout(false);
        InputPanel.ResumeLayout(false);
        InputPanel.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Button ZeroButton;
    private Button OneButton;
    private Button TwoButton;
    private Button ThreeButton;
    private Button FourButton;
    private Button FiveButton;
    private Button SixButton;
    private Button SevenButton;
    private Button EightButton;
    private Button NineButton;
    private Button AddButton;
    private Button SubtractButton;
    private Button MultiplyButton;
    private Button DivideButton;
    private Button EqualsButton;
    private Button ClearButton;
    private GroupBox CalculatorGroupBox;
    private Panel InputPanel;
    private Label ExpressionLabel;
    private Label ResultLabel;
}