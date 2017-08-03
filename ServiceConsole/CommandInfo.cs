using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceConsole
{
    class CommandInfo
    {
        public string Command { get; set; }
        public string Value { get; set; }
        public OptionCollection Options { get; set; }
        public OptionCollection Additionals { get; set; }
        public bool IsError { get; private set; }

        public static CommandInfo Create(string command)
        {
            var cmd = new CommandInfo();
            cmd.SetCommand(command);
            return cmd;
        }

        public void SetCommand(string command)
        {
            command = command.Trim(' ');
            var cIndex = command.IndexOf(' ');


            if (cIndex > 0 && cIndex < command.Length)
            {
                // Catch Command
                Command = command.Substring(0, cIndex);
                string rest = command;

                bool isDone = false;
                bool isCommand = false;
                while(!isDone)
                {
                    if (rest.Length != 0)
                    {

                    }
                    else
                    {
                        isDone = true;
                    }


                    rest = command.Substring(cIndex).TrimStart(' ');
                    if (rest.Length != 0)
                    {
                        int vIndex = rest.IndexOf(' ');

                        if (vIndex != -1)
                        {
                            Value = rest.Substring(0, vIndex);
                        }
                        else
                        {
                            Value = rest;
                        }

                        IsError = false;
                    }
                }
            }

            IsError = true;
        }
    }
}
