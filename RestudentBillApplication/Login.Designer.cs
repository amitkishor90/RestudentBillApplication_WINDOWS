namespace RestudentBillApplication;

partial class Login
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
        label1 = new Label();
        label2 = new Label();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        button1 = new Button();
        button2 = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(156, 59);
        label1.Name = "label1";
        label1.Size = new Size(133, 30);
        label1.TabIndex = 0;
        label1.Text = "UserName :";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        label2.Location = new Point(156, 112);
        label2.Name = "label2";
        label2.Size = new Size(130, 30);
        label2.TabIndex = 1;
        label2.Text = "Password  :";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(306, 58);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(280, 31);
        textBox1.TabIndex = 2;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(306, 112);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(280, 31);
        textBox2.TabIndex = 3;
        // 
        // button1
        // 
        button1.Location = new Point(306, 185);
        button1.Name = "button1";
        button1.Size = new Size(147, 41);
        button1.TabIndex = 4;
        button1.Text = "LogIn";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new Point(474, 185);
        button2.Name = "button2";
        button2.Size = new Size(112, 41);
        button2.TabIndex = 5;
        button2.Text = "Exit";
        button2.UseVisualStyleBackColor = true;
        // 
        // Login
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(label2);
        Controls.Add(label1);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "Login";
        Text = "Login";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox textBox1;
    private TextBox textBox2;
    private Button button1;
    private Button button2;
}
