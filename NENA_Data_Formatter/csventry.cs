using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _911Updater
{
    public class csventry
    {
        public string Function_Code_1 { get; set; }
        public string NPA_3 { get; set; }
        public string Calling_Number_7 { get; set; }
        public string House_Number_10 { get; set; }
        public string House_Number_Suffix_4 { get; set; }
        public string Prefix_Directional_2 { get; set; }
        public string Street_Name_60 { get; set; }
        public string Street_Suffix_4 { get; set; }
        public string Post_Directional_2 { get; set; }
        public string Community_Name_32 { get; set; }
        public string State_2 { get; set; }
        public string Location_60 { get; set; }
        public string Customer_Name_32 { get; set; }
        public string Class_Of_Service_1 { get; set; }
        public string Type_Of_Service_1 { get; set; }
        public string Exchange_4 { get; set; }
        public string ESN_5 { get; set; }
        public string Main_NPA_3 { get; set; }
        public string Main_Number_7 { get; set; }
        public string Order_Number_10 { get; set; }
        public string Extract_Date_6 { get; set; }
        public string County_ID_4 { get; set; }
        public string Access_Infra_Provider_5 { get; set; }
        public string Source_ID_1 { get; set; }
        public string Zip_Code_5 { get; set; }
        public string Zip_4_4 { get; set; }
        public string General_Use_11 { get; set; }
        public string Customer_Code_3 { get; set; }
        public string Comments_30 { get; set; }
        public string X_Coordinate_9 { get; set; }
        public string Y_Coordinate_9 { get; set; }
        public string Z_Coordinate_5 { get; set; }
        public string Cell_ID_6 { get; set; }
        public string Sector_ID_1 { get; set; }
        public string TAR_Code_6 { get; set; }
        public string Reserved_21 { get; set; }
        public string Alt_Number_10 { get; set; }
        public string Expanded_Extract_Date_8 { get; set; }
        public string NENA_Reserved_81 { get; set; }
        public string Data_Provider_ID_5 { get; set; }
        public string Reserved_31 { get; set; }
        public string End_Of_Record_1 { get; set; }

        public csventry(string Function_Code, string NPA, string Calling_Number, string House_Number, string House_Number_Suffix,
            string Prefix_Directional, string Street_Name, string Street_Suffix, string Post_Directional,
            string Community_Name, string State, string Location, string Customer_Name, string Class_of_Service,
            string Type_of_Service, string Exchange, string ESN, string Main_NPA, string Main_Number,
            string Order_Number, string Extract_Date, string County_ID, string Access_Infra_Provider, string Source_ID,
            string Zip_Code, string Zip_4, string General_Use, string Customer_Code, string Comments,
            string X_Coordinate, string Y_Coordinate, string Z_Coordinate, string Cell_ID, string Sector_ID,
            string TAR_Code, string Reserved1, string Alt_Number, string Expanded_Extract_Date, string NENA_Reserved,
            string Data_Provider_ID, string Reserved2, string End_of_Record)
        {
            Function_Code_1 = Function_Code.PadRight(1);
            NPA_3 = NPA.PadRight(3);
            Calling_Number_7 = Calling_Number.PadRight(7);
            House_Number_10 = House_Number.PadRight(10);
            House_Number_Suffix_4 = House_Number_Suffix.PadRight(4);
            Prefix_Directional_2 = Prefix_Directional.PadRight(2);
            Street_Name_60 = Street_Name.PadRight(60);
            Street_Suffix_4 = Street_Suffix.PadRight(4);
            Post_Directional_2 = Post_Directional.PadRight(2);
            Community_Name_32 = Community_Name.PadRight(32);
            State_2 = State.PadRight(2);
            Location_60 = Location.PadRight(60);
            Customer_Name_32 = Customer_Name.PadRight(32);
            Class_Of_Service_1 = Class_of_Service.PadRight(1);
            Type_Of_Service_1 = Type_of_Service.PadRight(1);
            Exchange_4 = Exchange.PadRight(4);
            ESN_5 = ESN.PadRight(5);
            Main_NPA_3 = Main_NPA.PadRight(3);
            Main_Number_7 = Main_Number.PadRight(7);
            Order_Number_10 = Order_Number.PadRight(10);
            Extract_Date_6 = Extract_Date.PadRight(6);
            County_ID_4 = County_ID.PadRight(4);
            Access_Infra_Provider_5 = Access_Infra_Provider.PadRight(5);
            Source_ID_1 = Source_ID.PadRight(1);
            Zip_Code_5 = Zip_Code.PadRight(5);
            Zip_4_4 = Zip_4.PadRight(4);
            General_Use_11 = General_Use.PadRight(11);
            Customer_Code_3 = Customer_Code.PadRight(3);
            Comments_30 = Comments.PadRight(30);
            X_Coordinate_9 = X_Coordinate.PadRight(9);
            Y_Coordinate_9 = Y_Coordinate.PadRight(9);
            Z_Coordinate_5 = Z_Coordinate.PadRight(5);
            Cell_ID_6 = Cell_ID.PadRight(6);
            Sector_ID_1 = Sector_ID.PadRight(1);
            TAR_Code_6 = TAR_Code.PadRight(6);
            Reserved_21 = Reserved1.PadRight(21);
            Alt_Number_10 = Alt_Number.PadRight(10);
            Expanded_Extract_Date_8 = Expanded_Extract_Date.PadRight(8);
            NENA_Reserved_81 = NENA_Reserved.PadRight(81);
            Data_Provider_ID_5 = Data_Provider_ID.PadRight(5);
            Reserved_31 = Reserved2.PadRight(31);
            End_Of_Record_1 = End_of_Record.PadRight(1);


        }

        public override string ToString()
        {
            //return base.ToString();
            return Function_Code_1 + NPA_3 + Calling_Number_7 + House_Number_10 + House_Number_Suffix_4
                + Prefix_Directional_2 + Street_Name_60 + Street_Suffix_4 + Post_Directional_2
                + Community_Name_32 + State_2 + Location_60 + Customer_Name_32 + Class_Of_Service_1
                + Type_Of_Service_1 + Exchange_4 + ESN_5 + Main_NPA_3 + Main_Number_7
                + Order_Number_10 + Extract_Date_6 + County_ID_4 + Access_Infra_Provider_5 + Source_ID_1
                + Zip_Code_5 + Zip_4_4 + General_Use_11 + Customer_Code_3 + Comments_30
                + X_Coordinate_9 + Y_Coordinate_9 + Z_Coordinate_5 + Cell_ID_6 + Sector_ID_1
                + TAR_Code_6 + Reserved_21 + Alt_Number_10 + Expanded_Extract_Date_8 + NENA_Reserved_81
                + Data_Provider_ID_5 + Reserved_31 + End_Of_Record_1;
        }

    }
}
