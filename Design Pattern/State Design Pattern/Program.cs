using State_Design_Pattern.Services;

class Program
{
    static void Main(string[] args)
    {
        HandelReq gender = new HandelReq();
        ///var data = gender.GetGender();

            Gender gender1= new Female();
            var context = new Person(gender1);
            context.Request1();
            context.Request2();


        
    }



///Context: Transition to ConcreteStateA.
///ConcreteStateA handles request1.
///ConcreteStateA wants to change the state of the context.
///Context: Transition to ConcreteStateB.
///ConcreteStateB handles request2.
///ConcreteStateB wants to change the state of the context.
///Context: Transition to ConcreteStateA.
}
