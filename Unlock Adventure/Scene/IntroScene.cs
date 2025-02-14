﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unlock_Adventure.Core;

namespace Unlock_Adventure.Scene
{
    public class IntroScene : IScene
    {
        public void Enter()
        {
            Console.WriteLine(@"
 ================================
    Unlock Adventure
 ================================
 어둠 속에서 빛나는 화면...
 새로운 시작이 당신을 기다립니다.
 아무 키나 눌러 시작하세요...");
        }

        public void Update()
        {
            // 입력 대기는 InputSystem에서 처리
        }

        public void Exit()
        {
            Console.Clear();
        }
    }
}
