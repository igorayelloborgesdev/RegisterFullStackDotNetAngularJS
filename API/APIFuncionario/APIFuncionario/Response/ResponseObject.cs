using APIFuncionario.IResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIFuncionario.Response
{
    public class ResponseObject<T> : IResponseObject<T>
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public T responseObj { get; set; }
        public IEnumerable<T> responseObjList { get; set; }

        public ResponseObject<T> SetMessage(string message)
        {
            this.Message = message;
            return this;
        }
        public ResponseObject<T> SetSuccess(bool success)
        {
            this.Success = success;
            return this;
        }
        public ResponseObject<T> SetResponseObj(T responseObj)
        {
            this.responseObj = responseObj;
            return this;
        }
        public ResponseObject<T> SetResponseObjList(IEnumerable<T> responseObjList)
        {
            this.responseObjList = responseObjList;
            return this;
        }
        public ResponseObject<T> Build()
        {
            this.Message = Message;
            this.Success = Success;
            this.responseObj = responseObj;
            this.responseObjList = responseObjList;
            return this;
        }
    }
}