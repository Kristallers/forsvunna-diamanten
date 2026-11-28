// FALL #2
// VAD: Subtypspolymorfism och beroendeinjektion.
// HUR: Vi skapar gränssnittet IChoice som implementeras av två subtyper: NationChoice och QuizChoice. 
// VARFÖR: Eftersom vi vill att spelarens val ska behandlas på samma sätt. Genom att både NationChoice och QuizChoice implementerar IChoice kan programmet köra ActionOfChoice() utan att veta vilken typ av val det är. 
public interface IChoice
{
    void ActionOfChoice();
}