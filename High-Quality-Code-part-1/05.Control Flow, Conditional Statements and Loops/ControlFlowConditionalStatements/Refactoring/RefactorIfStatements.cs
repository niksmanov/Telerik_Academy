namespace ControlFlowConditionalStatementsLoops.Refactoring
{
    using ControlFlowConditionalStatementsLoops.Contracts;

    internal class RefactorIfStatements
    {
        /// First if statement from homework
        internal void CookPotato(IPotato potato)
        {
            bool isPotatoNotNull = potato != null;
            bool isPotatoReadyForCook = !potato.IsPealed && !potato.IsRotten;

            if (isPotatoNotNull && isPotatoReadyForCook)
            {
                this.CookPotato(potato);
            }
        }

        /// Second if statement from homework  
        internal void VisitedCell(uint x, uint y)
        {
            uint minX = uint.MinValue;
            uint maxX = uint.MaxValue;
            uint minY = uint.MinValue;
            uint maxY = uint.MaxValue;
            bool visited = true;
            bool isValidX = x >= minX && x <= maxX;
            bool isValidY = maxY >= y && minY <= y;
            bool result = false;
            
            if (isValidX && isValidY && !visited)
            {
                result = visited;
            }

            this.VisitedCell(x, y);
        }
    }
}