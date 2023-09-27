using System.Runtime.Serialization;




namespace SquareProject.Models

{

    [Serializable]

    internal class SquareSideCannotBeNegativeOrZero : Exception

    {

        public SquareSideCannotBeNegativeOrZero()

        {

        }




        public SquareSideCannotBeNegativeOrZero(string? message) : base(message)

        {

        }




        public SquareSideCannotBeNegativeOrZero(string? message, Exception? innerException) : base(message, innerException)

        {

        }




        protected SquareSideCannotBeNegativeOrZero(SerializationInfo info, StreamingContext context) : base(info, context)

        {

        }

    }

}