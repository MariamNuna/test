namespace WindowsFormWeb
{
    partial class FormMise_a_jour
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomgLabel;
            System.Windows.Forms.Label datecreationLabel;
            System.Windows.Forms.Label datemodificationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMise_a_jour));
            this.dS1 = new WindowsFormWeb.DS1();
            this.groupeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupeTableAdapter = new WindowsFormWeb.DS1TableAdapters.groupeTableAdapter();
            this.tableAdapterManager = new WindowsFormWeb.DS1TableAdapters.TableAdapterManager();
            this.groupeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butaj = new System.Windows.Forms.Button();
            this.butmod = new System.Windows.Forms.Button();
            this.butsup = new System.Windows.Forms.Button();
            this.butqt = new System.Windows.Forms.Button();
            this.nomgTextBox = new System.Windows.Forms.TextBox();
            this.datecreationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datemodificationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            nomgLabel = new System.Windows.Forms.Label();
            datecreationLabel = new System.Windows.Forms.Label();
            datemodificationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupeBindingNavigator)).BeginInit();
            this.groupeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nomgLabel
            // 
            nomgLabel.AutoSize = true;
            nomgLabel.Location = new System.Drawing.Point(493, 54);
            nomgLabel.Name = "nomgLabel";
            nomgLabel.Size = new System.Drawing.Size(36, 13);
            nomgLabel.TabIndex = 8;
            nomgLabel.Text = "nomg:";
            // 
            // datecreationLabel
            // 
            datecreationLabel.AutoSize = true;
            datecreationLabel.Location = new System.Drawing.Point(493, 81);
            datecreationLabel.Name = "datecreationLabel";
            datecreationLabel.Size = new System.Drawing.Size(69, 13);
            datecreationLabel.TabIndex = 10;
            datecreationLabel.Text = "datecreation:";
            // 
            // datemodificationLabel
            // 
            datemodificationLabel.AutoSize = true;
            datemodificationLabel.Location = new System.Drawing.Point(493, 107);
            datemodificationLabel.Name = "datemodificationLabel";
            datemodificationLabel.Size = new System.Drawing.Size(87, 13);
            datemodificationLabel.TabIndex = 12;
            datemodificationLabel.Text = "datemodification:";
            // 
            // dS1
            // 
            this.dS1.DataSetName = "DS1";
            this.dS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupeBindingSource
            // 
            this.groupeBindingSource.DataMember = "groupe";
            this.groupeBindingSource.DataSource = this.dS1;
            // 
            // groupeTableAdapter
            // 
            this.groupeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.groupeTableAdapter = this.groupeTableAdapter;
            this.tableAdapterManager.stagiaireTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormWeb.DS1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupeBindingNavigator
            // 
            this.groupeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.groupeBindingNavigator.BindingSource = this.groupeBindingSource;
            this.groupeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.groupeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.groupeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.groupeBindingNavigatorSaveItem});
            this.groupeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.groupeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.groupeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.groupeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.groupeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.groupeBindingNavigator.Name = "groupeBindingNavigator";
            this.groupeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.groupeBindingNavigator.Size = new System.Drawing.Size(796, 25);
            this.groupeBindingNavigator.TabIndex = 0;
            this.groupeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // groupeBindingNavigatorSaveItem
            // 
            this.groupeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.groupeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("groupeBindingNavigatorSaveItem.Image")));
            this.groupeBindingNavigatorSaveItem.Name = "groupeBindingNavigatorSaveItem";
            this.groupeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.groupeBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.groupeBindingNavigatorSaveItem.Click += new System.EventHandler(this.groupeBindingNavigatorSaveItem_Click);
            // 
            // groupeDataGridView
            // 
            this.groupeDataGridView.AllowUserToAddRows = false;
            this.groupeDataGridView.AllowUserToDeleteRows = false;
            this.groupeDataGridView.AutoGenerateColumns = false;
            this.groupeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.groupeDataGridView.DataSource = this.groupeBindingSource;
            this.groupeDataGridView.Location = new System.Drawing.Point(12, 28);
            this.groupeDataGridView.Name = "groupeDataGridView";
            this.groupeDataGridView.ReadOnly = true;
            this.groupeDataGridView.Size = new System.Drawing.Size(449, 220);
            this.groupeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idg";
            this.dataGridViewTextBoxColumn1.HeaderText = "idg";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomg";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomg";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "datecreation";
            this.dataGridViewTextBoxColumn3.HeaderText = "datecreation";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "datemodification";
            this.dataGridViewTextBoxColumn4.HeaderText = "datemodification";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // butaj
            // 
            this.butaj.Location = new System.Drawing.Point(12, 272);
            this.butaj.Name = "butaj";
            this.butaj.Size = new System.Drawing.Size(75, 23);
            this.butaj.TabIndex = 2;
            this.butaj.Text = "Ajouter";
            this.butaj.UseVisualStyleBackColor = true;
            this.butaj.Click += new System.EventHandler(this.butaj_Click);
            // 
            // butmod
            // 
            this.butmod.Location = new System.Drawing.Point(131, 272);
            this.butmod.Name = "butmod";
            this.butmod.Size = new System.Drawing.Size(75, 23);
            this.butmod.TabIndex = 3;
            this.butmod.Text = "Modifier";
            this.butmod.UseVisualStyleBackColor = true;
            this.butmod.Click += new System.EventHandler(this.butmod_Click);
            // 
            // butsup
            // 
            this.butsup.Location = new System.Drawing.Point(258, 272);
            this.butsup.Name = "butsup";
            this.butsup.Size = new System.Drawing.Size(75, 23);
            this.butsup.TabIndex = 4;
            this.butsup.Text = "Supprimer";
            this.butsup.UseVisualStyleBackColor = true;
            this.butsup.Click += new System.EventHandler(this.butsup_Click);
            // 
            // butqt
            // 
            this.butqt.Location = new System.Drawing.Point(376, 272);
            this.butqt.Name = "butqt";
            this.butqt.Size = new System.Drawing.Size(75, 23);
            this.butqt.TabIndex = 5;
            this.butqt.Text = "Quitter";
            this.butqt.UseVisualStyleBackColor = true;
            this.butqt.Click += new System.EventHandler(this.butqt_Click);
            // 
            // nomgTextBox
            // 
            this.nomgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupeBindingSource, "nomg", true));
            this.nomgTextBox.Location = new System.Drawing.Point(586, 51);
            this.nomgTextBox.Name = "nomgTextBox";
            this.nomgTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomgTextBox.TabIndex = 9;
            // 
            // datecreationDateTimePicker
            // 
            this.datecreationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.groupeBindingSource, "datecreation", true));
            this.datecreationDateTimePicker.Location = new System.Drawing.Point(586, 77);
            this.datecreationDateTimePicker.Name = "datecreationDateTimePicker";
            this.datecreationDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datecreationDateTimePicker.TabIndex = 11;
            // 
            // datemodificationDateTimePicker
            // 
            this.datemodificationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.groupeBindingSource, "datemodification", true));
            this.datemodificationDateTimePicker.Location = new System.Drawing.Point(586, 103);
            this.datemodificationDateTimePicker.Name = "datemodificationDateTimePicker";
            this.datemodificationDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datemodificationDateTimePicker.TabIndex = 13;
            // 
            // FormMise_a_jour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 312);
            this.Controls.Add(nomgLabel);
            this.Controls.Add(this.nomgTextBox);
            this.Controls.Add(datecreationLabel);
            this.Controls.Add(this.datecreationDateTimePicker);
            this.Controls.Add(datemodificationLabel);
            this.Controls.Add(this.datemodificationDateTimePicker);
            this.Controls.Add(this.butqt);
            this.Controls.Add(this.butsup);
            this.Controls.Add(this.butmod);
            this.Controls.Add(this.butaj);
            this.Controls.Add(this.groupeDataGridView);
            this.Controls.Add(this.groupeBindingNavigator);
            this.Name = "FormMise_a_jour";
            this.Text = "FormMise_a_jour";
            this.Load += new System.EventHandler(this.FormMise_a_jour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupeBindingNavigator)).EndInit();
            this.groupeBindingNavigator.ResumeLayout(false);
            this.groupeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS1 dS1;
        private System.Windows.Forms.BindingSource groupeBindingSource;
        private DS1TableAdapters.groupeTableAdapter groupeTableAdapter;
        private DS1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator groupeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton groupeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView groupeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button butaj;
        private System.Windows.Forms.Button butmod;
        private System.Windows.Forms.Button butsup;
        private System.Windows.Forms.Button butqt;
        private System.Windows.Forms.TextBox nomgTextBox;
        private System.Windows.Forms.DateTimePicker datecreationDateTimePicker;
        private System.Windows.Forms.DateTimePicker datemodificationDateTimePicker;
    }
}