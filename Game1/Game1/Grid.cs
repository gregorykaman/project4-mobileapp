using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    public class Grid
    {
        int BlockSize = 32;
        int BoardWidth = 12;
        int BoardHeight = 22;

        public void Draw(SpriteBatch spriteBatch, Texture2D block)
        {
            int pos_y = 0;
            for (int i = 0; i < BoardHeight; i++)
            {
                int pos_x = 300-192;
                for (int ii = 0; ii < BoardWidth; ii++)
                {
                    if (i == 0 || i == 21 || ii == 0 || ii == 11)
                    {
                        spriteBatch.Draw(block, new Vector2(pos_x, pos_y), Color.DarkBlue);
                    }
                    else
                    {
                        //spriteBatch.Draw(block, new Vector2(pos_x, pos_y), Color.White);
                    }
                    pos_x += BlockSize;
                }
                pos_y += BlockSize;
            }
        }
    }
}
