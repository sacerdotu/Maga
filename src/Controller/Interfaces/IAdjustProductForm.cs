using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Interfaces
{
    public interface IAdjustProductForm
    {
        int GetGridSelectedColumnIndex();
        void SetBtnStergeEnabled(bool enable);
        void SetBtnAdaugaEnabled(bool enable);
    }
}
