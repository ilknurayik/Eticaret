using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eticaret.Entity;

namespace Eticaret.Common
{
    public class ResultProcess<T>
    {
        public Result<int> GetResult(ECommerceEntities db)
            //db'ye kayıt yapmak için kullanacağımız yardımcı method
        {
            Result<int> result = new Result<int>();

            int sonuc = db.SaveChanges();
            if (sonuc>0)
            {
                result.UserMessage = "Basarili";
                result.IsSucceeded = true;
                result.ProcessResult = sonuc;
            }
            else
            {
                result.UserMessage = "Basarısız";
                result.IsSucceeded = false;
                result.ProcessResult = sonuc;
            }

            return result;
        }

        public Result<List<T>> GetListResult(List<T> data)
        {
            //db'den liste tipinde data çekerken datanın olup olmadığını kontrol eden method
            Result<List<T>> result = new Result<List<T>>();

            if (data != null)
            {
                result.UserMessage = "İşlem başarılı";
                result.IsSucceeded = true;
                result.ProcessResult = data;
            }
            else
            {
                result.UserMessage = "İşlem başarısız data yok";
                result.IsSucceeded = false;
                result.ProcessResult = data;
            }

            return result;
        }

        public Result<T> GetT(T data)
        {
            Result<T> result = new Result<T>();

            if (data != null)
            {
                result.UserMessage = "Başarılı";
                result.IsSucceeded = true;
                result.ProcessResult = data;
            }
            else
            {
                result.UserMessage = "Başarısız";
                result.IsSucceeded = false;
                result.ProcessResult = data;
            }

            return result;
        }
    }
}
