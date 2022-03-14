using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chemex.ViewModels
{
    public class ResultModel
    {
        public Results status;
        public object Response;
        public string Message;

        public static ResultModel ResultOK(){
            return new ResultModel() {status = Results.Success};
        }
        public static ResultModel ResultOK(object response){
            return new ResultModel() {status = Results.Success, Response = response};
        }
        public static ResultModel ResultError(string message){
            return new ResultModel() {status = Results.Success, Message = message};
        }
    }

    public enum Results
    {
        Success,
        Error
    }
}
