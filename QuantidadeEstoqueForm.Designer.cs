namespace trabaio
{
    partial class QuantidadeEstoqueForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            quantidadeNumericUpDown = new NumericUpDown();
            cancelarButton = new Button();
            confirmarButton = new Button();
            quantidadeLabel = new Label();
            filialLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)quantidadeNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // quantidadeNumericUpDown
            // 
            quantidadeNumericUpDown.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantidadeNumericUpDown.Location = new Point(132, 159);
            quantidadeNumericUpDown.Name = "quantidadeNumericUpDown";
            quantidadeNumericUpDown.Size = new Size(151, 33);
            quantidadeNumericUpDown.TabIndex = 0;
            quantidadeNumericUpDown.TextAlign = HorizontalAlignment.Center;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(216, 225);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(157, 43);
            cancelarButton.TabIndex = 1;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // confirmarButton
            // 
            confirmarButton.Location = new Point(32, 225);
            confirmarButton.Name = "confirmarButton";
            confirmarButton.Size = new Size(157, 43);
            confirmarButton.TabIndex = 2;
            confirmarButton.Text = "Confirmar";
            confirmarButton.UseVisualStyleBackColor = true;
            confirmarButton.Click += confirmarButton_Click;
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantidadeLabel.Location = new Point(75, 106);
            quantidadeLabel.Margin = new Padding(3);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new Size(232, 25);
            quantidadeLabel.TabIndex = 3;
            quantidadeLabel.Text = "                                            ";
            // 
            // filialLabel
            // 
            filialLabel.AutoSize = true;
            filialLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filialLabel.Location = new Point(75, 50);
            filialLabel.Margin = new Padding(3);
            filialLabel.Name = "filialLabel";
            filialLabel.Size = new Size(232, 25);
            filialLabel.TabIndex = 4;
            filialLabel.Text = "                                            ";
            // 
            // QuantidadeEstoqueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 309);
            Controls.Add(filialLabel);
            Controls.Add(quantidadeLabel);
            Controls.Add(confirmarButton);
            Controls.Add(cancelarButton);
            Controls.Add(quantidadeNumericUpDown);
            Name = "QuantidadeEstoqueForm";
            Text = "QuantidadeEstoqueForm";
            ((System.ComponentModel.ISupportInitialize)quantidadeNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown quantidadeNumericUpDown;
        private Button cancelarButton;
        private Button confirmarButton;
        private Label quantidadeLabel;
        private Label filialLabel;
    }
}