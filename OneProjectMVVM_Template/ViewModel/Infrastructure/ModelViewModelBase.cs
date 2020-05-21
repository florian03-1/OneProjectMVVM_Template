using OneProjectMVVM_Template.Model.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneProjectMVVM_Template.ViewModel.Infrastructure
{
    public abstract class ModelViewModelBase<T> : ViewModelBase where T: ModelBase
    {
        public T ModelObject { get; set; }

        public Guid ID
        {
            get { return ModelObject.ID; }
            set { ModelObject.ID = value; RaisePropertyChanged(); }
        }        

        public string Comment
        {
            get { return ModelObject.Comment; }
            set { ModelObject.Comment = value; RaisePropertyChanged(); }
        }

        public string CreatedBy
        {
            get { return ModelObject.CreatedBy; }
            set { ModelObject.CreatedBy = value; RaisePropertyChanged(); }
        }

        public DateTime CreationTimestamp
        {
            get { return ModelObject.CreationTimestamp; }
            set { ModelObject.CreationTimestamp = value; RaisePropertyChanged(); }
        }

        public string LastModifiedBy
        {
            get { return ModelObject.LastModifiedBy; }
            set { ModelObject.LastModifiedBy = value; RaisePropertyChanged(); }
        }

        public DateTime LastModifiedTimestamp
        {
            get { return ModelObject.LastModifiedTimestamp; }
            set { ModelObject.LastModifiedTimestamp = value; RaisePropertyChanged(); }
        }
    }
}
