using System;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordGenerator
{
    internal class ResizeTool
    {
        private Form resizeForm;
        private Panel workspace;
        public ResizeTool(Form resizeForm, Panel workspace)
        {
            this.resizeForm = resizeForm;
            this.workspace = workspace;
            LinkEvents(workspace);
        }

        public void LinkEvents(Control control)
        {
            control.MouseMove += OnPanelMouseMove;
            control.MouseUp += OnPanelMouseUp;
            control.MouseDown += OnPanelMouseDown;
            control.MouseLeave += OnPanelMouseLeave;
        }

        public void UnlinkEvents(Control control)
        {
            control.MouseMove -= OnPanelMouseMove;
            control.MouseUp -= OnPanelMouseUp;
            control.MouseDown -= OnPanelMouseDown;
            control.MouseLeave -= OnPanelMouseLeave;
            OnPanelMouseLeave(null,null);
        }

        private bool isDraggingHorisontal;
        private bool isDraggingVertical;

        private void OnPanelMouseMove(object sender, MouseEventArgs e)
        {
            bool sizeXready = e.X >= workspace.Width - 4;
            bool sizeYready = e.Y >= workspace.Height - 4;
            if (sizeYready)
            {
                resizeForm.Cursor = Cursors.SizeNS;
            }
            else if (sizeXready)
            {
                resizeForm.Cursor = Cursors.SizeWE;
            }
            else
            {
                resizeForm.Cursor = Cursors.Default;
            }

            if (isDraggingHorisontal)
            {
                resizeForm.Size = new Size(workspace.Location.X + workspace.Size.Width + (e.X - workspace.Size.Width), resizeForm.Height);
            }
            else if (isDraggingVertical)
            {
                resizeForm.Size = new Size(resizeForm.Width, workspace.Location.Y + workspace.Size.Height + (e.Y - workspace.Size.Height));
            }
        }

        private void OnPanelMouseUp(object sender, MouseEventArgs e)
        {
            isDraggingHorisontal = isDraggingVertical = false;
        }

        private void OnPanelMouseDown(object sender, MouseEventArgs e)
        {
            if (e.X >= workspace.Width - 4)
            {
                isDraggingHorisontal = true;
            }
            else if (e.Y >= workspace.Height - 4)
            {
                isDraggingVertical = true;
            }
        }

        private void OnPanelMouseLeave(object sender, EventArgs e)
        {
            resizeForm.Cursor = Cursors.Default;
            isDraggingHorisontal = isDraggingVertical = false;
        }
    }
}
