using TurtleLibrary;
using TurtleX.TreeStructures;

namespace TurtleX.Interpreter
{

    public class OperatorPlus : Operator
    {
        public static void addKostil()
        {
            OperatorFactory.operatorRegister.Add("+", (ie1, ie2) => { return new OperatorPlus(ie1, ie2);}); 
        }
      
        public OperatorPlus(IExpression left, IExpression right)
            : base(left, right)
        {
            // do nothing
        }
        public override double eval()
        {
            double leftValue = this.left.eval();
            double rightValue = this.right.eval();
            return leftValue + rightValue; 
        }
    }
}
