using System;

class Program {
    static void Main(string[] args) {
        /* Information: Student  */
        String stud_firstName = "John";
        String stud_lastName  = "Yang";
        String stud_birth     = "1991.07.24";
        String stud_address01 = "Taipei";
        String stud_address02 = "London";
        String stud_city      = "Taipei";
        String stud_state     = "None";
        int    stud_zipCode   = 114;
        String stud_country   = "Taiwan";

        Console.WriteLine("#########################################");
        Console.WriteLine("Student First Name: " + stud_firstName);
        Console.WriteLine("Student Last  Name: " + stud_lastName);
        Console.WriteLine("Student Birth Date: " + stud_birth);
        Console.WriteLine("Student Address 01: " + stud_address01);
        Console.WriteLine("Student Address 02: " + stud_address02);
        Console.WriteLine("Student City      : " + stud_city);
        Console.WriteLine("Student State     : " + stud_state);
        Console.WriteLine("Student Zip Code  : " + stud_zipCode);
        Console.WriteLine("Student Country   : " + stud_country);

        /* Information: Teacher  */
        String teach_firstName = "Steven";
        String teach_lastName = "Ko";
        String teach_birth = "1911.01.30";
        String teach_address01 = "Taipei";
        String teach_address02 = "London";
        String teach_city = "Taipei";
        String teach_state = "None";
        int teach_zipCode = 114;
        String teach_country = "Taiwan";

        Console.WriteLine("#########################################");
        Console.WriteLine("Teacher First Name: " + stud_firstName);
        Console.WriteLine("Teacher Last  Name: " + stud_lastName);
        Console.WriteLine("Teacher Birth Date: " + stud_birth);
        Console.WriteLine("Teacher Address 01: " + stud_address01);
        Console.WriteLine("Teacher Address 02: " + stud_address02);
        Console.WriteLine("Teacher City      : " + stud_city);
        Console.WriteLine("Teacher State     : " + stud_state);
        Console.WriteLine("Teacher Zip Code  : " + stud_zipCode);
        Console.WriteLine("Teacher Country   : " + stud_country);

        /* Information: UProgram */
        String prog_name = "LifeScience";
        String prog_department = "MolecularBiology";
        String prog_deg = "PhD";

        Console.WriteLine("#########################################");
        Console.WriteLine("Program   : " + prog_name);
        Console.WriteLine("Department: " + prog_department);
        Console.WriteLine("Degree    : " + prog_deg);

        /* Information: Degree   */
        String deg_name = "PhD";
        String deg_require = "First author in two publish paper";

        Console.WriteLine("#########################################");
        Console.WriteLine("Degree            : " + deg_name);
        Console.WriteLine("Credit Requirement: " + deg_require);
        
        /* Information: Course   */
        String course_name = "ProgrammingC#";
        int course_credit = 3;
        int course_weeks = 8;
        String course_teacher = "Steven";

        Console.WriteLine("#########################################");
        Console.WriteLine("Course        : " + course_name);
        Console.WriteLine("Credit        : " + course_credit);
        Console.WriteLine("Duration Weeks: " + course_weeks);
        Console.WriteLine("Teacher       : " + course_teacher);

    } // end main
} // end class 

