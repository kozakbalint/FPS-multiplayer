using System;
using System.Collections.Generic;
using System.Text;

namespace FPS_multiplayer_server
{
    class GameLogic
    {
        public static void Update()
        {
            ThreadManager.UpdateMain();
        }
    }
}
