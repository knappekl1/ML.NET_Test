// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace ConsoleApp1ML.Model
{
    public class ModelInput
    {
        [ColumnName("label"), LoadColumn(0)]
        public string Label { get; set; }


        [ColumnName("message"), LoadColumn(1)]
        public string Message { get; set; }


        [ColumnName("length"), LoadColumn(2)]
        public float Length { get; set; }


        [ColumnName("punct"), LoadColumn(3)]
        public float Punct { get; set; }


    }
}