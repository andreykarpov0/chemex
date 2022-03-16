using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chemex.ViewModels
{
    public class ResultModel
    {
        public Results status {get; set;}
        public object Response {get; set;}
        public string Message {get; set;}

        public static ResultModel ResultOK(){
            return new ResultModel() {status = Results.Success, Message = "Успешно выполнено"};
        }
        public static ResultModel ResultOK(object response){
            return new ResultModel() {status = Results.Success, Message = "Успешно выполнено", Response = response};
        }
        public static ResultModel ResultError(string message = "Ошибка"){
            return new ResultModel() {status = Results.Error, Message = message};
        }
    }

    public enum Results
    {
        Success = 0,
        Error
    }
}
