namespace UpdateGCode;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        open_btn = new System.Windows.Forms.Button();
        change_btn = new System.Windows.Forms.Button();
        save_btn = new System.Windows.Forms.Button();
        textBox = new System.Windows.Forms.TextBox();
        checkBox_default = new System.Windows.Forms.CheckBox();
        textBox_insertBefore = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        textBox_commandToUpdate = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        textBox_insertAfter = new System.Windows.Forms.TextBox();
        textBox_commandToIgnire = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // open_btn
        // 
        open_btn.Location = new System.Drawing.Point(12, 36);
        open_btn.Name = "open_btn";
        open_btn.Size = new System.Drawing.Size(110, 86);
        open_btn.TabIndex = 0;
        open_btn.Text = "Open";
        open_btn.UseVisualStyleBackColor = true;
        open_btn.Click += open_btn_Click;
        // 
        // change_btn
        // 
        change_btn.Location = new System.Drawing.Point(12, 128);
        change_btn.Name = "change_btn";
        change_btn.Size = new System.Drawing.Size(110, 86);
        change_btn.TabIndex = 1;
        change_btn.Text = "Change";
        change_btn.UseVisualStyleBackColor = true;
        change_btn.Click += change_btn_Click;
        // 
        // save_btn
        // 
        save_btn.Location = new System.Drawing.Point(12, 220);
        save_btn.Name = "save_btn";
        save_btn.Size = new System.Drawing.Size(110, 86);
        save_btn.TabIndex = 2;
        save_btn.Text = "Save";
        save_btn.UseVisualStyleBackColor = true;
        save_btn.Click += save_btn_Click;
        // 
        // textBox
        // 
        textBox.Location = new System.Drawing.Point(454, 12);
        textBox.Multiline = true;
        textBox.Name = "textBox";
        textBox.ReadOnly = true;
        textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        textBox.Size = new System.Drawing.Size(334, 426);
        textBox.TabIndex = 3;
        // 
        // checkBox_default
        // 
        checkBox_default.Checked = true;
        checkBox_default.CheckState = System.Windows.Forms.CheckState.Checked;
        checkBox_default.Location = new System.Drawing.Point(157, 36);
        checkBox_default.Name = "checkBox_default";
        checkBox_default.Size = new System.Drawing.Size(170, 24);
        checkBox_default.TabIndex = 4;
        checkBox_default.Text = "Changes by default";
        checkBox_default.UseVisualStyleBackColor = true;
        checkBox_default.CheckedChanged += checkBox_default_CheckedChanged_1;
        // 
        // textBox_insertBefore
        // 
        textBox_insertBefore.Enabled = false;
        textBox_insertBefore.Location = new System.Drawing.Point(157, 89);
        textBox_insertBefore.Name = "textBox_insertBefore";
        textBox_insertBefore.Size = new System.Drawing.Size(100, 27);
        textBox_insertBefore.TabIndex = 5;
        textBox_insertBefore.Text = "M13";
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(157, 63);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 6;
        label1.Text = "Insert before";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(157, 119);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(156, 23);
        label2.TabIndex = 7;
        label2.Text = "Command to update";
        // 
        // textBox_commandToUpdate
        // 
        textBox_commandToUpdate.Enabled = false;
        textBox_commandToUpdate.Location = new System.Drawing.Point(157, 145);
        textBox_commandToUpdate.Name = "textBox_commandToUpdate";
        textBox_commandToUpdate.Size = new System.Drawing.Size(100, 27);
        textBox_commandToUpdate.TabIndex = 8;
        textBox_commandToUpdate.Text = "G0";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(157, 234);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 23);
        label3.TabIndex = 9;
        label3.Text = "Insert after";
        // 
        // textBox_insertAfter
        // 
        textBox_insertAfter.Enabled = false;
        textBox_insertAfter.Location = new System.Drawing.Point(157, 260);
        textBox_insertAfter.Name = "textBox_insertAfter";
        textBox_insertAfter.Size = new System.Drawing.Size(100, 27);
        textBox_insertAfter.TabIndex = 10;
        textBox_insertAfter.Text = "M12";
        // 
        // textBox_commandToIgnire
        // 
        textBox_commandToIgnire.Enabled = false;
        textBox_commandToIgnire.Location = new System.Drawing.Point(157, 201);
        textBox_commandToIgnire.Name = "textBox_commandToIgnire";
        textBox_commandToIgnire.Size = new System.Drawing.Size(100, 27);
        textBox_commandToIgnire.TabIndex = 12;
        textBox_commandToIgnire.Text = "G00";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(157, 175);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(156, 23);
        label4.TabIndex = 11;
        label4.Text = "Command to ignore\r\n";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(textBox_commandToIgnire);
        Controls.Add(label4);
        Controls.Add(textBox_insertAfter);
        Controls.Add(label3);
        Controls.Add(textBox_commandToUpdate);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(textBox_insertBefore);
        Controls.Add(checkBox_default);
        Controls.Add(textBox);
        Controls.Add(save_btn);
        Controls.Add(change_btn);
        Controls.Add(open_btn);
        Text = "Update GCode";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textBox_commandToIgnire;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.CheckBox checkBox_default;
    private System.Windows.Forms.TextBox textBox_insertBefore;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox_commandToUpdate;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox_insertAfter;

    private System.Windows.Forms.TextBox textBox;

    private System.Windows.Forms.Button change_btn;
    private System.Windows.Forms.Button save_btn;

    private System.Windows.Forms.Button open_btn;

    #endregion
}