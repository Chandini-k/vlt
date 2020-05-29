namespace WindowsFormsApp2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label categoryidLabel;
            System.Windows.Forms.Label subcategoryidLabel;
            System.Windows.Forms.Label itemnameLabel;
            System.Windows.Forms.Label imagenameLabel;
            this.buyerDataSet = new WindowsFormsApp2.BuyerDataSet();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new WindowsFormsApp2.BuyerDataSetTableAdapters.ItemsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.BuyerDataSetTableAdapters.TableAdapterManager();
            this.itemsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.itemsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.categoryidSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.subcategoryidSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.itemnameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.imagenamePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.itemsGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            idLabel = new System.Windows.Forms.Label();
            categoryidLabel = new System.Windows.Forms.Label();
            subcategoryidLabel = new System.Windows.Forms.Label();
            itemnameLabel = new System.Windows.Forms.Label();
            imagenameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buyerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingNavigator)).BeginInit();
            this.itemsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryidSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcategoryidSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemnameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenamePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buyerDataSet
            // 
            this.buyerDataSet.DataSetName = "BuyerDataSet";
            this.buyerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.buyerDataSet;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ItemsTableAdapter = this.itemsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.BuyerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // itemsBindingNavigator
            // 
            this.itemsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.itemsBindingNavigator.BindingSource = this.itemsBindingSource;
            this.itemsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.itemsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.itemsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.itemsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.itemsBindingNavigatorSaveItem});
            this.itemsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.itemsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.itemsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.itemsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.itemsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.itemsBindingNavigator.Name = "itemsBindingNavigator";
            this.itemsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.itemsBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.itemsBindingNavigator.TabIndex = 0;
            this.itemsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // itemsBindingNavigatorSaveItem
            // 
            this.itemsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("itemsBindingNavigatorSaveItem.Image")));
            this.itemsBindingNavigatorSaveItem.Name = "itemsBindingNavigatorSaveItem";
            this.itemsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.itemsBindingNavigatorSaveItem.Text = "Save Data";
            this.itemsBindingNavigatorSaveItem.Click += new System.EventHandler(this.itemsBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(507, 86);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // idSpinEdit
            // 
            this.idSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemsBindingSource, "id", true));
            this.idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idSpinEdit.Location = new System.Drawing.Point(614, 82);
            this.idSpinEdit.Name = "idSpinEdit";
            this.idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idSpinEdit.Size = new System.Drawing.Size(125, 24);
            this.idSpinEdit.TabIndex = 2;
            // 
            // categoryidLabel
            // 
            categoryidLabel.AutoSize = true;
            categoryidLabel.Location = new System.Drawing.Point(507, 115);
            categoryidLabel.Name = "categoryidLabel";
            categoryidLabel.Size = new System.Drawing.Size(78, 17);
            categoryidLabel.TabIndex = 3;
            categoryidLabel.Text = "categoryid:";
            // 
            // categoryidSpinEdit
            // 
            this.categoryidSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemsBindingSource, "categoryid", true));
            this.categoryidSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.categoryidSpinEdit.Location = new System.Drawing.Point(614, 112);
            this.categoryidSpinEdit.Name = "categoryidSpinEdit";
            this.categoryidSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.categoryidSpinEdit.Size = new System.Drawing.Size(125, 24);
            this.categoryidSpinEdit.TabIndex = 4;
            // 
            // subcategoryidLabel
            // 
            subcategoryidLabel.AutoSize = true;
            subcategoryidLabel.Location = new System.Drawing.Point(507, 145);
            subcategoryidLabel.Name = "subcategoryidLabel";
            subcategoryidLabel.Size = new System.Drawing.Size(101, 17);
            subcategoryidLabel.TabIndex = 5;
            subcategoryidLabel.Text = "subcategoryid:";
            // 
            // subcategoryidSpinEdit
            // 
            this.subcategoryidSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemsBindingSource, "subcategoryid", true));
            this.subcategoryidSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.subcategoryidSpinEdit.Location = new System.Drawing.Point(614, 142);
            this.subcategoryidSpinEdit.Name = "subcategoryidSpinEdit";
            this.subcategoryidSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.subcategoryidSpinEdit.Size = new System.Drawing.Size(125, 24);
            this.subcategoryidSpinEdit.TabIndex = 6;
            // 
            // itemnameLabel
            // 
            itemnameLabel.AutoSize = true;
            itemnameLabel.Location = new System.Drawing.Point(507, 175);
            itemnameLabel.Name = "itemnameLabel";
            itemnameLabel.Size = new System.Drawing.Size(73, 17);
            itemnameLabel.TabIndex = 7;
            itemnameLabel.Text = "itemname:";
            // 
            // itemnameTextEdit
            // 
            this.itemnameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemsBindingSource, "itemname", true));
            this.itemnameTextEdit.Location = new System.Drawing.Point(614, 172);
            this.itemnameTextEdit.Name = "itemnameTextEdit";
            this.itemnameTextEdit.Size = new System.Drawing.Size(125, 22);
            this.itemnameTextEdit.TabIndex = 8;
            // 
            // imagenameLabel
            // 
            imagenameLabel.AutoSize = true;
            imagenameLabel.Location = new System.Drawing.Point(507, 203);
            imagenameLabel.Name = "imagenameLabel";
            imagenameLabel.Size = new System.Drawing.Size(85, 17);
            imagenameLabel.TabIndex = 9;
            imagenameLabel.Text = "imagename:";
            // 
            // imagenamePictureEdit
            // 
            this.imagenamePictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemsBindingSource, "imagename", true));
            this.imagenamePictureEdit.Location = new System.Drawing.Point(510, 232);
            this.imagenamePictureEdit.Name = "imagenamePictureEdit";
            this.imagenamePictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.imagenamePictureEdit.Size = new System.Drawing.Size(245, 125);
            this.imagenamePictureEdit.TabIndex = 10;
            // 
            // itemsGridControl
            // 
            this.itemsGridControl.DataSource = this.itemsBindingSource;
            this.itemsGridControl.Location = new System.Drawing.Point(0, 49);
            this.itemsGridControl.MainView = this.gridView1;
            this.itemsGridControl.Name = "itemsGridControl";
            this.itemsGridControl.Size = new System.Drawing.Size(438, 317);
            this.itemsGridControl.TabIndex = 11;
            this.itemsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.itemsGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.itemsGridControl);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idSpinEdit);
            this.Controls.Add(categoryidLabel);
            this.Controls.Add(this.categoryidSpinEdit);
            this.Controls.Add(subcategoryidLabel);
            this.Controls.Add(this.subcategoryidSpinEdit);
            this.Controls.Add(itemnameLabel);
            this.Controls.Add(this.itemnameTextEdit);
            this.Controls.Add(imagenameLabel);
            this.Controls.Add(this.imagenamePictureEdit);
            this.Controls.Add(this.itemsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buyerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingNavigator)).EndInit();
            this.itemsBindingNavigator.ResumeLayout(false);
            this.itemsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryidSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcategoryidSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemnameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenamePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BuyerDataSet buyerDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private BuyerDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private BuyerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator itemsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton itemsBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.SpinEdit idSpinEdit;
        private DevExpress.XtraEditors.SpinEdit categoryidSpinEdit;
        private DevExpress.XtraEditors.SpinEdit subcategoryidSpinEdit;
        private DevExpress.XtraEditors.TextEdit itemnameTextEdit;
        private DevExpress.XtraEditors.PictureEdit imagenamePictureEdit;
        private DevExpress.XtraGrid.GridControl itemsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}

