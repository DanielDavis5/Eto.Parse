﻿namespace Eto.Parse.Parsers
{
    public class AnySurrogatePairTerminal : SurrogatePairTerminal
    {
        public AnySurrogatePairTerminal()
        {
        }

        protected AnySurrogatePairTerminal(AnySurrogatePairTerminal other, ParserCloneArgs args)
			: base(other, args)
		{
		}

        public override Parser Clone(ParserCloneArgs args)
        {
            return new AnySurrogatePairTerminal(this, args);
        }

        protected override bool Test(int codePoint)
        {
            return true;
        }
    }
}