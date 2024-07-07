namespace MultiAppProject
{
    partial class DrawingForm
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DrawingForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "DrawingForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingForm_MouseUp);
            this.ResumeLayout(false);
        }
    }
}
