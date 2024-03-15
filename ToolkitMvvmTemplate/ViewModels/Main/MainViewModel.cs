using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolkitMvvmTemplate.Bases;

namespace ToolkitMvvmTemplate.ViewModels.Main
{
    /// <summary>
    /// 메인 뷰모델 클래스
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// 생성자
        /// </summary>
        public MainViewModel()
        {
            Title = "Main View Test";
        }
    }
}
