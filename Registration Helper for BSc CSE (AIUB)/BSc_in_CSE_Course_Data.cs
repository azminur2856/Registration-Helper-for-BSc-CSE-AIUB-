using System.Collections.Generic;

namespace Registration_Helper_for_BSc_CSE_AIUB
{
    internal class BSc_in_CSE_Course_Data
    {
        public List<BSc_in_CSE_Curriculum> Course { get; }

        public BSc_in_CSE_Course_Data()
        {
            Course = new List<BSc_in_CSE_Curriculum>();

            // Add courses
            AddCourses();
        }

        private void AddCourses()
        {
            // Semester 1 courses
            Course.Add(new BSc_in_CSE_Curriculum("MAT1102", "DIFFERENTIAL CALCULUS & CO-ORDINATE GEOMETRY", "Nil", 3));
            Course.Add(new BSc_in_CSE_Curriculum("PHY1101", "PHYSICS 1", "Nil", 3));
            Course.Add(new BSc_in_CSE_Curriculum("PHY1102", "PHYSICS 1 LAB", "Nil", 1));
            Course.Add(new BSc_in_CSE_Curriculum("ENG1101", "ENGLISH READING SKILLS & PUBLIC SPEAKING", "Nil", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC1101", "INTRODUCTION TO COMPUTER STUDIES", "Nil", 1));
            Course.Add(new BSc_in_CSE_Curriculum("CSC1103", "INTRODUCTION TO PROGRAMMING LAB", "Nil", 1));
            Course.Add(new BSc_in_CSE_Curriculum("CSC1102", "INTRODUCTION TO PROGRAMMING", "Nil", 3));
            // Add other courses for Semester 1

            // Semester 2 courses
            Course.Add(new BSc_in_CSE_Curriculum("CSC1204", "DISCRETE MATHEMATICS", "MAT1102 & CSC1102", 3));
            Course.Add(new BSc_in_CSE_Curriculum("MAT1205", "INTEGRAL CALCULUS & ORDINARY DIFFERENTIAL EQUATIONS", "MAT1102", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC1205", "OBJECT ORIENTED PROGRAMMING 1", "CSC1102 & CSC1103", 3));
            Course.Add(new BSc_in_CSE_Curriculum("PHY1203", "PHYSICS 2", "PHY1101", 3));
            Course.Add(new BSc_in_CSE_Curriculum("PHY1204", "PHYSICS 2 LAB", "PHY1102", 1));
            Course.Add(new BSc_in_CSE_Curriculum("ENG1202", "ENGLISH WRITING SKILLS & COMMUNICATIONS", "ENG1101", 3));
            Course.Add(new BSc_in_CSE_Curriculum("COE2101", "INTRODUCTION TO ELECTRICAL CIRCUITS", "PHY1101", 3));
            Course.Add(new BSc_in_CSE_Curriculum("COE2102", "INTRODUCTION TO ELECTRICAL CIRCUITS LAB", "PHY1102", 1));
            // Add other courses for Semester 2

            // Semester 3 courses
            Course.Add(new BSc_in_CSE_Curriculum("CHEM1101", "CHEMISTRY", "PHY1203", 3));
            Course.Add(new BSc_in_CSE_Curriculum("MAT2101", "COMPLEX VARIABLE, LAPLACE & Z-TRANSFORMATION", "MAT1205", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC2108", "INTRODUCTION TO DATABASE", "CSC1205", 3));
            Course.Add(new BSc_in_CSE_Curriculum("EEE2104", "ELECTRONIC DEVICES LAB", "COE2102", 1));
            Course.Add(new BSc_in_CSE_Curriculum("BBA1102", "PRINCIPLES OF ACCOUNTING", "MAT1205", 3));
            Course.Add(new BSc_in_CSE_Curriculum("EEE2103", "ELECTRONIC DEVICES", "COE2101", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC2106", "DATA STRUCTURE", "CSC1204 & CSC1205", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC2107", "DATA STRUCTURE LAB", "CSC1204 & CSC1205", 1));
            Course.Add(new BSc_in_CSE_Curriculum("BAE2101", "COMPUTER AIDED DESIGN & DRAFTING", "Nil", 1));
            // Add other courses for Semester 3

            // Semester 4 courses
            Course.Add(new BSc_in_CSE_Curriculum("CSC2211", "ALGORITHMS", "CSC2106", 3));
            Course.Add(new BSc_in_CSE_Curriculum("MAT2202", "MATRICES, VECTORS, FOURIER ANALYSIS", "MAT2101", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC2210", "OBJECT ORIENTED PROGRAMMING 2", "CSC2106 CSC2108", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC2209", "OBJECT ORIENTED ANALYSIS AND DESIGN", "CSC2108", 3));
            Course.Add(new BSc_in_CSE_Curriculum("BAS2101", "BANGLADESH STUDIES", "CSC1101", 3));
            Course.Add(new BSc_in_CSE_Curriculum("EEE3101", "DIGITAL LOGIC AND CIRCUITS", "EEE2103", 3));
            Course.Add(new BSc_in_CSE_Curriculum("EEE3102", "DIGITAL LOGIC AND CIRCUITS LAB", "EEE2104", 1));
            Course.Add(new BSc_in_CSE_Curriculum("MAT3103", "COMPUTATIONAL STATISTICS AND PROBABILITY", "MAT2101", 3));
            // Add other courses for Semester 4

            // Semester 5 courses
            Course.Add(new BSc_in_CSE_Curriculum("CSC3113", "THEORY OF COMPUTATION", "CSC2211", 3));
            Course.Add(new BSc_in_CSE_Curriculum("ECO3150", "PRINCIPLES OF ECONOMICS", "MAT3103", 2));
            Course.Add(new BSc_in_CSE_Curriculum("ENG2103", "BUSINESS COMMUNICATION", "BAS2101", 3));
            Course.Add(new BSc_in_CSE_Curriculum("MAT3101", "NUMERICAL METHODS FOR SCIENCE AND ENGINEERING", "MAT2202", 3));
            Course.Add(new BSc_in_CSE_Curriculum("COE3103", "DATA COMMUNICATION", "EEE3101 & EEE3102", 3));
            Course.Add(new BSc_in_CSE_Curriculum("COE3104", "MICROPROCESSOR AND EMBEDDED SYSTEMS", "EEE3101 & EEE3102", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC3112", "SOFTWARE ENGINEERING", "CSC2209", 3));
            // Add other courses for Semester 5

            // Semester 6 courses
            Course.Add(new BSc_in_CSE_Curriculum("CSC3217", "ARTIFICIAL INTELLIGENCE AND EXPERT SYSTEM", "CSC2211 & MAT3103", 3));
            Course.Add(new BSc_in_CSE_Curriculum("COE3206", "COMPUTER NETWORKS", "COE3103", 3));
            Course.Add(new BSc_in_CSE_Curriculum("COE3205", "COMPUTER ORGANIZATION AND ARCHITECTURE", "COE3104", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC3214", "OPERATING SYSTEM", "CSC2211 & COE3104", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC3215", "WEB TECHNOLOGIES", "CSC3112", 3));
            Course.Add(new BSc_in_CSE_Curriculum("EEE2216", "ENGINEERING ETHICS", "CSC3112 & COE3104", 2));
            Course.Add(new BSc_in_CSE_Curriculum("CSC3216", "COMPILER DESIGN", "CSC3113", 3));
            // Add other courses for Semester 6

            // Semester 7 courses
            Course.Add(new BSc_in_CSE_Curriculum("CSC4118", "COMPUTER GRAPHICS", "CSC2211 & MAT2202", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC****", "COS ELECTIVE 1", "Nil", 3));
            Course.Add(new BSc_in_CSE_Curriculum("MGT3202", "ENGINEERING MANAGEMENT", "EEE2216", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC4197", "RESEARCH METHODOLOGY", "100 Credits", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC####", "CSE MAJOR 1", "Nil", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC####", "CSE MAJOR 2", "Nil", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC####", "CSE MAJOR 3", "Nil", 3));
            // Add other courses for Semester 7

            // Semester 8 courses
            Course.Add(new BSc_in_CSE_Curriculum("CSC4299", "THESIS", "CSC4197", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC****", "COS ELECTIVE 2", "Nil", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC4296", "INTERNSHIP", "139 Credits", 3));
            // Add other courses for Semester 8

            // Major in Information Systems (additional courses)
            Course.Add(new BSc_in_CSE_Curriculum("CSC4181", "ADVANCE DATABASE MANAGEMENT SYSTEM", "CSC2108", 3));
            Course.Add(new BSc_in_CSE_Curriculum("MIS3101", "MANAGEMENT INFORMATION SYSTEM", "CSC3112", 3));
            Course.Add(new BSc_in_CSE_Curriculum("MIS4011", "ENTERPRISE RESOURCE PLANNING", "MIS3101 & CSC3112", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC4285", "DATA WAREHOUSE AND DATA MINING", "CSC2211 & MAT3103", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC4182", "HUMAN COMPUTER INTERACTION", "CSC3217 & CSC3215", 3));
            Course.Add(new BSc_in_CSE_Curriculum("MIS4014", "BUSINESS INTELLIGENCE AND DECISION SUPPORT SYSTEMS", "", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC4180", "INTRODUCTION TO DATA SCIENCE", "", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC4183", "CYBER LAWS & INFORMATION SECURITY", "", 3));
            Course.Add(new BSc_in_CSE_Curriculum("MIS4007", "DIGITAL MARKETING", "", 3));
            Course.Add(new BSc_in_CSE_Curriculum("MIS4012", "E-COMMERCE, E-GOVERNANCE & E-SERIES", "", 3));

            // Major in Computational Theory (additional courses)
            Course.Add(new BSc_in_CSE_Curriculum("CSC4125", "COMPUTER SCIENCE MATHEMATICS", "CSC2211 & MAT3101", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC4126", "BASIC GRAPH THEORY", "CSC2211", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC4127", "ADVANCED ALGORITHM TECHNIQUES", "CSC3217", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC4233", "NATURAL LANGUAGE PROCESSING", "CSC3217 & CSC4162", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC4128", "LINEAR PROGRAMMING", "CSC3217 & MAT3103", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC4231", "PARALLEL COMPUTING", "CSC3217", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC4232", "MACHINE LEARNING", "CSC3217", 3));

            // Major in Software Engineering (additional courses)
            Course.Add(new BSc_in_CSE_Curriculum("CSC4270", "SOFTWARE DEVELOPMENT PROJECT MANAGEMENT", "CSC3112", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC4160", "SOFTWARE REQUIREMENT ENGINEERING", "CSC3112", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC4271", "SOFTWARE QUALITY AND TESTING", "CSC3112", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC4162", "PROGRAMMING IN PYTHON", "CSC3215", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC4274", "VIRTUAL REALITY SYSTEMS DESIGN", "CSC2210", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC4163", "ADVANCED PROGRAMMING WITH JAVA", "CSC3215", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC4164", "ADVANCED PROGRAMMING WITH .NET", "CSC3215", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC4161", "ADVANCED PROGRAMMING IN WEB TECHNOLOGY", "CSC3215", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC4272", "MOBILE APPLICATION DEVELOPMENT", "CSC3215", 3));
            Course.Add(new BSc_in_CSE_Curriculum("CSC4273", "SOFTWARE ARCHITECTURE AND DESIGN PATTERNS", "CSC3112", 3));

            // Major in Computer Engineering (additional courses)
            Course.Add(new BSc_in_CSE_Curriculum("BAE1201", "BASIC MECHANICAL ENGG.", "PHY1203", 3));
            Course.Add(new BSc_in_CSE_Curriculum("EEE3103", "DIGITAL SIGNAL PROCESSING", "EEE2213", 3));
            Course.Add(new BSc_in_CSE_Curriculum("EEE4217", "VLSI CIRCUIT DESIGN", "EEE 3101 & EEE 3102", 3));
            Course.Add(new BSc_in_CSE_Curriculum("EEE2213", "SIGNALS & LINEAR SYSTEM", "MAT2202", 3));
            Course.Add(new BSc_in_CSE_Curriculum("COE4128", "DIGITAL SYSTEM DESIGN", "COE3205", 3));
            Course.Add(new BSc_in_CSE_Curriculum("COE4231", "IMAGE PROCESSING", "CSC4118 & EEE2213", 3));
            Course.Add(new BSc_in_CSE_Curriculum("COE4129", "MULTIMEDIA SYSTEMS", "CSC3215", 3));
            Course.Add(new BSc_in_CSE_Curriculum("COE4230", "SIMULATION & MODELING", "CSC3217", 3));
            Course.Add(new BSc_in_CSE_Curriculum("COE4126", "ADVANCED COMPUTER NETWORKS", "COE3206", 3));
            Course.Add(new BSc_in_CSE_Curriculum("COE4234", "COMPUTER VISION AND PATTERN RECOGNITION", "CSC4118", 3));
            Course.Add(new BSc_in_CSE_Curriculum("COE4232", "NETWORK SECURITY", "COE3103", 3));
            Course.Add(new BSc_in_CSE_Curriculum("COE4125", "ADVANCED OPERATING SYSTEM", "CSC3214", 3));
            Course.Add(new BSc_in_CSE_Curriculum("EEE4233", "DIGITAL DESIGN WITH SYSTEM [ VERILOG,VHDL & FPGAS ]", "EEE4217", 3));
            Course.Add(new BSc_in_CSE_Curriculum("COE4235", "ROBOTICS ENGINEERING", "CSC3217", 3));
            Course.Add(new BSc_in_CSE_Curriculum("EEE4209", "TELECOMMUNICATIONS ENGINEERING", "COE3103", 3));
            Course.Add(new BSc_in_CSE_Curriculum("COE4127", "NETWORK RESOURCE MANAGEMENT & ORGANIZATION", "COE3103", 3));
            Course.Add(new BSc_in_CSE_Curriculum("COE4233", "WIRELESS SENSOR NETWORKS", "COE3103", 3));
            Course.Add(new BSc_in_CSE_Curriculum("EEE4241", "INDUSTRIAL ELECTRONICS, DRIVES & INSTRUMENTATION", "EEE3101", 3));
        }
    }
}
