using System;
namespace WSUniversalLib
{
    public class Calculation
    {
        public int GetPriorityForAgent(float age, float experience, int agentType)
        {
            double agentCoefficient = 0.0;

            switch (agentType)
            {
                case 1:
                    agentCoefficient = 1.8;
                    break;
                case 2:
                    agentCoefficient = 3.2;
                    break;
                case 3:
                    agentCoefficient = 4.1;
                    break;
                default:
                    return -1;
            }

            if (experience > 40)
            {
                agentCoefficient += 0.9;
            }
            else if (experience > 20)
            {
                agentCoefficient += 0.7;
            }
            else if (experience > 10)
            {
                agentCoefficient += 0.5;
            }

            if (age <= 25 && experience <= 3)
            {
                switch (agentType)
                {
                    case 1:
                        agentCoefficient += 0.1;
                        break;
                    case 2:
                        agentCoefficient += 0.17;
                        break;
                    case 3:
                        agentCoefficient += 0.26;
                        break;
                }
            }

            double agentPriority = agentCoefficient * experience;
            int roundedPriority = (int)Math.Round(agentPriority);

            return roundedPriority;
        }
    }
}
