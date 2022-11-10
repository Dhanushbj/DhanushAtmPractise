using System;

namespace Assignment
{
    class Instructor
    {
        float avgFeedback;
        int experience;
        string instructorName;
        String[] instructorSkill;
        private object instructorName1;
        private object ins;

        public bool checkSkill(String technology)
        {
            for (int i = 0; i< instructorSkill.Length; i++)
            {
                if(technology == instructorSkill[i])
                {
                    if (validateEligibility())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public Instructor()
        {
            Console.WriteLine("Default constructor");
        }

        public Instructor(string instructorName,float avgFeedback,int experience,string[] instructorSkill)
        {
            this.instructorName = instructorName;
            this.avgFeedback = avgFeedback;
            this.experience = experience;
            this.instructorSkill = instructorSkill;
        }

        public Instructor(object instructorName1, object ins)
        {
            this.instructorName1 = instructorName1;
            this.ins = ins;
        }

        public bool validateEligibility()
        {
            if(experience > 3)
            {
                if (avgFeedback >= 4.5)
                {
                    return true;
                }
            }
            else
            {
                if (avgFeedback >= 4)
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assigments 1");
            float avgFeedback = 4.5f;
            int experience = 10;
            string instructorName = "harry";
            string[] instructorSkill = { "c#", "c++", "dotnet", "java" };
            Instructor instructor = new Instructor(instructorName, avgFeedback, experience, instructorSkill);
            if(instructor.validateEligibility() && instructor.checkSkill("python"))
            {
                Console.WriteLine("Instructor is eligible in teaching");

            }
            else
            {
                Console.WriteLine("Instructor is not eligible in teaching");
            }

        }
    }
}


            



                
            

    
