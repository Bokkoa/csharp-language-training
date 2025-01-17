namespace Winforms;

partial class Form1
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        btnStart = new Button();
        loadingGIF = new PictureBox();
        label1 = new Label();
        txtInput = new TextBox();
        pgCards = new ProgressBar();
        btnCancel = new Button();
        ((System.ComponentModel.ISupportInitialize)loadingGIF).BeginInit();
        SuspendLayout();
        // 
        // btnStart
        // 
        btnStart.Location = new Point(93, 71);
        btnStart.Name = "btnStart";
        btnStart.Size = new Size(75, 23);
        btnStart.TabIndex = 0;
        btnStart.Text = "Start";
        btnStart.UseVisualStyleBackColor = true;
        btnStart.Click += btnStart_Click;
        // 
        // loadingGIF
        // 
        loadingGIF.Image = (Image)resources.GetObject("loadingGIF.Image");
        loadingGIF.Location = new Point(93, 119);
        loadingGIF.Name = "loadingGIF";
        loadingGIF.Size = new Size(150, 135);
        loadingGIF.SizeMode = PictureBoxSizeMode.CenterImage;
        loadingGIF.TabIndex = 1;
        loadingGIF.TabStop = false;
        loadingGIF.Visible = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 31);
        label1.Name = "label1";
        label1.Size = new Size(35, 15);
        label1.TabIndex = 2;
        label1.Text = "Input";
        // 
        // txtInput
        // 
        txtInput.Location = new Point(93, 28);
        txtInput.Name = "txtInput";
        txtInput.Size = new Size(100, 23);
        txtInput.TabIndex = 3;
        // 
        // pgCards
        // 
        pgCards.Location = new Point(93, 260);
        pgCards.Name = "pgCards";
        pgCards.Size = new Size(150, 23);
        pgCards.TabIndex = 4;
        pgCards.Visible = false;
        // 
        // btnCancel
        // 
        btnCancel.Location = new Point(186, 71);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(75, 23);
        btnCancel.TabIndex = 5;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnCancel);
        Controls.Add(pgCards);
        Controls.Add(txtInput);
        Controls.Add(label1);
        Controls.Add(loadingGIF);
        Controls.Add(btnStart);
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)loadingGIF).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnStart;
    private PictureBox loadingGIF;
    private Label label1;
    private TextBox txtInput;
    private ProgressBar pgCards;
    private Button btnCancel;
}
