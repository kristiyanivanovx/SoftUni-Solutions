﻿using SOLID.Models.Enumeration;
using SOLID.Models.Interfaces;

namespace SOLID.Models.Appenders
{
    public abstract class Appender : IAppender
    {
        protected int messagesAppended;

        protected Appender(ILayout layout, Level level)
        {
            this.Layout = layout;
            this.Level = level;
        }

        public ILayout Layout { get; }

        public Level Level { get; }

        public abstract void Append(IError error);

        public override string ToString()
        {
            return @$"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.Level}, Messages appended: {this.messagesAppended}";
        }
    }
}
