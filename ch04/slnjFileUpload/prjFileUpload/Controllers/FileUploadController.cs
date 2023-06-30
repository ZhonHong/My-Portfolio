using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;//檔案處理須引用System,IO命名空間

namespace prjFileUpload.Controllers
{
    public class FileUploadController : Controller
    {
        // GET: FileUpload
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(HttpPostedFileBase[] photos)
        {
            //上傳圖檔名稱
            string fileName = "";
            //使用for迴圈取得所有上傳的檔案
            for (int i = 0; i < photos.Length; i++)
            {
            //取得目前檔案上傳的HttpPostFileBase物件
            //即需引數的photos[i]可以取得第i個所上傳的檔案
            HttpPostedFileBase f = (HttpPostedFileBase)photos[i];
                //若目前檔案上傳的HttpPostedFileBase物件的檔案名稱為不為空白
                //即表示第i個f物件有指定上傳檔案
            
            //檔案上傳
                if (f != null)
                    {
              
                    //取得圖檔名稱
                    fileName = Path.GetFileName(f.FileName);
                    var path = Path.Combine(Server.MapPath("~/Photos"), fileName);
                    f.SaveAs(path);
                    }
            }
            return RedirectToAction("ShowPhotos");
        }
        //ShowPhotos方法使用ContentResult傳回HTML
        //可顯示Photos資料夾下所有圖檔
        public ContentResult ShowPhotos()
        {
            string strHtml = "" ;
            //建立可操作Photos資料夾物件
            DirectoryInfo dir = new DirectoryInfo(Server.MapPath("~/Photos"));
            //取得dir物件下的所有檔案(即photos資料夾下)並放入finfo檔案資料陣列中
            FileInfo[] finfo = dir.GetFiles();
            //逐一將finfo檔案資訊陣列內的所有圖檔指定給strHtml變數
            foreach (FileInfo result in finfo) 
            {
                //將顯示圖的HTML字串指定給strHTML
                strHtml += $"<a href='../Photos/{result.Name}' target='_blank'>" 
                    + $"<img src ='../Photos/{result.Name}' width='150' heigth='120' border='0'>" 
                    + $"</a> ";
              
            }
            //strHTML變數再加上 '返回' Create()動作方法的連結
            strHtml += "<p><a href ='Create'>返回</a></p>";
            return Content(strHtml, "text/html", System.Text.Encoding.UTF8);
        }
    }
}