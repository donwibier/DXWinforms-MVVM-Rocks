namespace Webinar.Views
{
    partial class TrackView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtEditId = new DevExpress.XtraEditors.TextEdit();
            this.txtEditName = new DevExpress.XtraEditors.TextEdit();
            this.txtEditComposer = new DevExpress.XtraEditors.TextEdit();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtEditId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditComposer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEditId
            // 
            this.txtEditId.Location = new System.Drawing.Point(76, 99);
            this.txtEditId.Name = "txtEditId";
            this.txtEditId.Size = new System.Drawing.Size(232, 20);
            this.txtEditId.TabIndex = 0;
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(76, 125);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(232, 20);
            this.txtEditName.TabIndex = 1;
            // 
            // txtEditComposer
            // 
            this.txtEditComposer.Location = new System.Drawing.Point(76, 152);
            this.txtEditComposer.Name = "txtEditComposer";
            this.txtEditComposer.Size = new System.Drawing.Size(232, 20);
            this.txtEditComposer.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(76, 32);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear Name";
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.BindingExpressions.AddRange(new DevExpress.Utils.MVVM.BindingExpression[] {
            DevExpress.Utils.MVVM.BindingExpression.CreatePropertyBinding(typeof(Webinar.ViewModels.TrackViewModel), "TrackId", this.txtEditId, "EditValue"),
            DevExpress.Utils.MVVM.BindingExpression.CreatePropertyBinding(typeof(Webinar.ViewModels.TrackViewModel), "Name", this.txtEditName, "EditValue"),
            DevExpress.Utils.MVVM.BindingExpression.CreatePropertyBinding(typeof(Webinar.ViewModels.TrackViewModel), "Composer", this.txtEditComposer, "EditValue"),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(Webinar.ViewModels.TrackViewModel), "ResetName", this.btnClear)});
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterMessageBoxService(null, false, DevExpress.Utils.MVVM.Services.DefaultMessageBoxServiceType.Default)});
            this.mvvmContext1.ViewModelType = typeof(Webinar.ViewModels.TrackViewModel);
            // 
            // TrackView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtEditComposer);
            this.Controls.Add(this.txtEditName);
            this.Controls.Add(this.txtEditId);
            this.Name = "TrackView";
            this.Size = new System.Drawing.Size(458, 422);
            ((System.ComponentModel.ISupportInitialize)(this.txtEditId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditComposer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraEditors.TextEdit txtEditComposer;
        private DevExpress.XtraEditors.TextEdit txtEditName;
        private DevExpress.XtraEditors.TextEdit txtEditId;
        private DevExpress.XtraEditors.SimpleButton btnClear;
    }
}
