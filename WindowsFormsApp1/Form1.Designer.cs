namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listOfPlanets = new System.Windows.Forms.ListBox();
            this.listOfColonies = new System.Windows.Forms.ListBox();
            this.listOfBuildings = new System.Windows.Forms.ListBox();
            this.planetInfo = new System.Windows.Forms.RichTextBox();
            this.buttonPlanet = new System.Windows.Forms.Button();
            this.buttonStartColony = new System.Windows.Forms.Button();
            this.buttonBuildResBuilding = new System.Windows.Forms.Button();
            this.buttonBuildUnitBuilding = new System.Windows.Forms.Button();
            this.buildInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listOfPlanets
            // 
            this.listOfPlanets.FormattingEnabled = true;
            this.listOfPlanets.ItemHeight = 16;
            this.listOfPlanets.Location = new System.Drawing.Point(12, 12);
            this.listOfPlanets.Name = "listOfPlanets";
            this.listOfPlanets.Size = new System.Drawing.Size(120, 388);
            this.listOfPlanets.TabIndex = 0;
            this.listOfPlanets.SelectedIndexChanged += new System.EventHandler(this.listOfPlanets_SelectedIndexChanged);
            // 
            // listOfColonies
            // 
            this.listOfColonies.FormattingEnabled = true;
            this.listOfColonies.ItemHeight = 16;
            this.listOfColonies.Location = new System.Drawing.Point(138, 12);
            this.listOfColonies.Name = "listOfColonies";
            this.listOfColonies.Size = new System.Drawing.Size(139, 388);
            this.listOfColonies.TabIndex = 1;
            this.listOfColonies.SelectedIndexChanged += new System.EventHandler(this.listOfColonies_SelectedIndexChanged);
            // 
            // listOfBuildings
            // 
            this.listOfBuildings.FormattingEnabled = true;
            this.listOfBuildings.ItemHeight = 16;
            this.listOfBuildings.Location = new System.Drawing.Point(283, 12);
            this.listOfBuildings.Name = "listOfBuildings";
            this.listOfBuildings.Size = new System.Drawing.Size(136, 340);
            this.listOfBuildings.TabIndex = 2;
            // 
            // planetInfo
            // 
            this.planetInfo.Location = new System.Drawing.Point(425, 12);
            this.planetInfo.Name = "planetInfo";
            this.planetInfo.Size = new System.Drawing.Size(363, 206);
            this.planetInfo.TabIndex = 4;
            this.planetInfo.Text = "";
            // 
            // buttonPlanet
            // 
            this.buttonPlanet.Location = new System.Drawing.Point(12, 406);
            this.buttonPlanet.Name = "buttonPlanet";
            this.buttonPlanet.Size = new System.Drawing.Size(120, 42);
            this.buttonPlanet.TabIndex = 5;
            this.buttonPlanet.Text = "Найти планету";
            this.buttonPlanet.UseVisualStyleBackColor = true;
            this.buttonPlanet.Click += new System.EventHandler(this.buttonPlanet_Click);
            // 
            // buttonStartColony
            // 
            this.buttonStartColony.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartColony.Location = new System.Drawing.Point(138, 406);
            this.buttonStartColony.Name = "buttonStartColony";
            this.buttonStartColony.Size = new System.Drawing.Size(139, 42);
            this.buttonStartColony.TabIndex = 6;
            this.buttonStartColony.Text = "Колонизация(постройка штаба)";
            this.buttonStartColony.UseVisualStyleBackColor = true;
            this.buttonStartColony.Click += new System.EventHandler(this.buttonStartColony_Click);
            // 
            // buttonBuildResBuilding
            // 
            this.buttonBuildResBuilding.Location = new System.Drawing.Point(283, 358);
            this.buttonBuildResBuilding.Name = "buttonBuildResBuilding";
            this.buttonBuildResBuilding.Size = new System.Drawing.Size(136, 42);
            this.buttonBuildResBuilding.TabIndex = 7;
            this.buttonBuildResBuilding.Text = "Построить добытчик";
            this.buttonBuildResBuilding.UseVisualStyleBackColor = true;
            this.buttonBuildResBuilding.Click += new System.EventHandler(this.buttonBuildResBuilding_Click);
            // 
            // buttonBuildUnitBuilding
            // 
            this.buttonBuildUnitBuilding.Location = new System.Drawing.Point(283, 406);
            this.buttonBuildUnitBuilding.Name = "buttonBuildUnitBuilding";
            this.buttonBuildUnitBuilding.Size = new System.Drawing.Size(136, 42);
            this.buttonBuildUnitBuilding.TabIndex = 8;
            this.buttonBuildUnitBuilding.Text = "Построить дом";
            this.buttonBuildUnitBuilding.UseVisualStyleBackColor = true;
            this.buttonBuildUnitBuilding.Click += new System.EventHandler(this.buttonBuildUnitBuilding_Click);
            // 
            // buildInfo
            // 
            this.buildInfo.Location = new System.Drawing.Point(425, 224);
            this.buildInfo.Name = "buildInfo";
            this.buildInfo.Size = new System.Drawing.Size(363, 214);
            this.buildInfo.TabIndex = 9;
            this.buildInfo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buildInfo);
            this.Controls.Add(this.buttonBuildUnitBuilding);
            this.Controls.Add(this.buttonBuildResBuilding);
            this.Controls.Add(this.buttonStartColony);
            this.Controls.Add(this.buttonPlanet);
            this.Controls.Add(this.planetInfo);
            this.Controls.Add(this.listOfBuildings);
            this.Controls.Add(this.listOfColonies);
            this.Controls.Add(this.listOfPlanets);
            this.Name = "Form1";
            this.Text = "Cosmic Stratery";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listOfPlanets;
        private System.Windows.Forms.ListBox listOfColonies;
        private System.Windows.Forms.ListBox listOfBuildings;
        private System.Windows.Forms.RichTextBox planetInfo;
        private System.Windows.Forms.Button buttonPlanet;
        private System.Windows.Forms.Button buttonStartColony;
        private System.Windows.Forms.Button buttonBuildResBuilding;
        private System.Windows.Forms.Button buttonBuildUnitBuilding;
        private System.Windows.Forms.RichTextBox buildInfo;
    }
}

