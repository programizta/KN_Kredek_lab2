namespace PiotrKoleczeklab2
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonAddHorse = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelFavNumberHorse = new System.Windows.Forms.Label();
            this.labelHorseName = new System.Windows.Forms.Label();
            this.labelUnicornColor = new System.Windows.Forms.Label();
            this.textBoxUnicornColor = new System.Windows.Forms.TextBox();
            this.buttonAddUnicorn = new System.Windows.Forms.Button();
            this.textBoxNumOfObjects = new System.Windows.Forms.TextBox();
            this.labelNumberOfInstances = new System.Windows.Forms.Label();
            this.buttonDeleteObjects = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Comic Sans MS", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserName.Location = new System.Drawing.Point(278, 9);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(239, 46);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Piotr Kołeczek";
            // 
            // buttonAddHorse
            // 
            this.buttonAddHorse.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddHorse.Location = new System.Drawing.Point(40, 226);
            this.buttonAddHorse.Name = "buttonAddHorse";
            this.buttonAddHorse.Size = new System.Drawing.Size(329, 41);
            this.buttonAddHorse.TabIndex = 1;
            this.buttonAddHorse.Text = "Dodaj konia";
            this.buttonAddHorse.UseVisualStyleBackColor = true;
            this.buttonAddHorse.Click += new System.EventHandler(this.buttonAddHorse_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxName.Location = new System.Drawing.Point(214, 158);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(155, 30);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNumber.Location = new System.Drawing.Point(214, 104);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(155, 30);
            this.textBoxNumber.TabIndex = 3;
            // 
            // labelFavNumberHorse
            // 
            this.labelFavNumberHorse.AutoSize = true;
            this.labelFavNumberHorse.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFavNumberHorse.Location = new System.Drawing.Point(36, 107);
            this.labelFavNumberHorse.Name = "labelFavNumberHorse";
            this.labelFavNumberHorse.Size = new System.Drawing.Size(172, 23);
            this.labelFavNumberHorse.TabIndex = 4;
            this.labelFavNumberHorse.Text = "Ulubiona liczba konia:";
            // 
            // labelHorseName
            // 
            this.labelHorseName.AutoSize = true;
            this.labelHorseName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHorseName.Location = new System.Drawing.Point(36, 161);
            this.labelHorseName.Name = "labelHorseName";
            this.labelHorseName.Size = new System.Drawing.Size(107, 23);
            this.labelHorseName.TabIndex = 5;
            this.labelHorseName.Text = "Nazwa konia:";
            // 
            // labelUnicornColor
            // 
            this.labelUnicornColor.AutoSize = true;
            this.labelUnicornColor.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUnicornColor.Location = new System.Drawing.Point(424, 107);
            this.labelUnicornColor.Name = "labelUnicornColor";
            this.labelUnicornColor.Size = new System.Drawing.Size(139, 23);
            this.labelUnicornColor.TabIndex = 6;
            this.labelUnicornColor.Text = "Kolor jednorożca:";
            // 
            // textBoxUnicornColor
            // 
            this.textBoxUnicornColor.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUnicornColor.Location = new System.Drawing.Point(604, 100);
            this.textBoxUnicornColor.Name = "textBoxUnicornColor";
            this.textBoxUnicornColor.Size = new System.Drawing.Size(154, 30);
            this.textBoxUnicornColor.TabIndex = 9;
            // 
            // buttonAddUnicorn
            // 
            this.buttonAddUnicorn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddUnicorn.Location = new System.Drawing.Point(417, 226);
            this.buttonAddUnicorn.Name = "buttonAddUnicorn";
            this.buttonAddUnicorn.Size = new System.Drawing.Size(341, 41);
            this.buttonAddUnicorn.TabIndex = 10;
            this.buttonAddUnicorn.Text = "Dodaj jednorożca";
            this.buttonAddUnicorn.UseVisualStyleBackColor = true;
            this.buttonAddUnicorn.Click += new System.EventHandler(this.buttonAddUnicorn_Click);
            // 
            // textBoxNumOfObjects
            // 
            this.textBoxNumOfObjects.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNumOfObjects.Location = new System.Drawing.Point(269, 289);
            this.textBoxNumOfObjects.Name = "textBoxNumOfObjects";
            this.textBoxNumOfObjects.Size = new System.Drawing.Size(100, 30);
            this.textBoxNumOfObjects.TabIndex = 11;
            // 
            // labelNumberOfInstances
            // 
            this.labelNumberOfInstances.AutoSize = true;
            this.labelNumberOfInstances.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNumberOfInstances.Location = new System.Drawing.Point(36, 292);
            this.labelNumberOfInstances.Name = "labelNumberOfInstances";
            this.labelNumberOfInstances.Size = new System.Drawing.Size(217, 23);
            this.labelNumberOfInstances.TabIndex = 12;
            this.labelNumberOfInstances.Text = "Liczba koniowatych w liście:";
            // 
            // buttonDeleteObjects
            // 
            this.buttonDeleteObjects.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteObjects.Location = new System.Drawing.Point(417, 284);
            this.buttonDeleteObjects.Name = "buttonDeleteObjects";
            this.buttonDeleteObjects.Size = new System.Drawing.Size(341, 39);
            this.buttonDeleteObjects.TabIndex = 13;
            this.buttonDeleteObjects.Text = "Usuń wszystkie koniowate z listy";
            this.buttonDeleteObjects.UseVisualStyleBackColor = true;
            this.buttonDeleteObjects.Click += new System.EventHandler(this.buttonDeleteObjects_Click);
            // 
            // timer1
            // 
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 376);
            this.Controls.Add(this.buttonDeleteObjects);
            this.Controls.Add(this.labelNumberOfInstances);
            this.Controls.Add(this.textBoxNumOfObjects);
            this.Controls.Add(this.buttonAddUnicorn);
            this.Controls.Add(this.textBoxUnicornColor);
            this.Controls.Add(this.labelUnicornColor);
            this.Controls.Add(this.labelHorseName);
            this.Controls.Add(this.labelFavNumberHorse);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonAddHorse);
            this.Controls.Add(this.labelUserName);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonAddHorse;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelFavNumberHorse;
        private System.Windows.Forms.Label labelHorseName;
        private System.Windows.Forms.Label labelUnicornColor;
        private System.Windows.Forms.TextBox textBoxUnicornColor;
        private System.Windows.Forms.Button buttonAddUnicorn;
        private System.Windows.Forms.TextBox textBoxNumOfObjects;
        private System.Windows.Forms.Label labelNumberOfInstances;
        private System.Windows.Forms.Button buttonDeleteObjects;
        private System.Windows.Forms.Timer timer1;
    }
}

