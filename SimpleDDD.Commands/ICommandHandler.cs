﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDDD.Commands
{
    public interface ICommandHandler<T> where T : ICommand
    {
        void Execute(T command);
    }
}
