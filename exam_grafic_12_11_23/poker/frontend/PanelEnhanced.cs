using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poker.frontend
{
    internal class PanelEnhanced : Panel
    {
        /// <summary>
        /// событие OnPaintBackground
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Перегружаем функцию стирания фона базового класса,
            // Решение проблемы обновления окна, увеличения и мерцания изображения
            return;
        }

        /// <summary>
        /// событие OnPaint
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            // Используем двойную буферизацию
            this.DoubleBuffered = true;
            // перерисовка фона перемещается сюда
            if (this.BackgroundImage != null)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                e.Graphics.DrawImage(
                    this.BackgroundImage,
                    new System.Drawing.Rectangle(0, 0, this.Width, this.Height),
                    0,
                    0,
                    this.BackgroundImage.Width,
                    this.BackgroundImage.Height,
                    System.Drawing.GraphicsUnit.Pixel);
            }
            base.OnPaint(e);
        }
    }
}
