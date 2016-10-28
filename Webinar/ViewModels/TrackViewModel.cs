using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System.ComponentModel;

namespace Webinar.ViewModels
{
    [POCOViewModel]
    public class TrackViewModel : IEditableObject
    {
        private TrackInfo _track;

        //protected TrackViewModel()
        //{
        //    // for test purposes only !!
        //    track = new TrackList()[32];
        //    Load(track);
        //}
        protected TrackViewModel() : this(new TrackList()[32]) { }
        protected TrackViewModel(TrackInfo track)
        {
            if (track == null)
                throw new ArgumentNullException("track", "track is null.");
            Load(track);
        }
        public static TrackViewModel Create()
        {
            return ViewModelSource.Create(() => new TrackViewModel());
        }
        public static TrackViewModel Create(TrackInfo track)
        {
            return ViewModelSource.Create(() => new TrackViewModel(track));
        }
        public bool CanResetName()
        {
            return _track != null && !String.IsNullOrEmpty(Name);
        }
        public void ResetName()
        {
            if (_track != null)
            {
                if (MessageBoxService.ShowMessage("Are you sure you want to reset the Name value?",
                                    "Question",
                                    MessageButton.YesNo,
                                    MessageIcon.Question,
                                    MessageResult.No) == MessageResult.Yes)
                    Name = "";
            }
        }

        [ServiceProperty(SearchMode = ServiceSearchMode.PreferParents)]
        protected virtual IMessageBoxService MessageBoxService { get { return null; } }

        private void Load(TrackInfo track)
        {
            this._track = track;
            this.TrackId = _track.TrackId;
            this.Name = _track.Name;
            this.Composer = _track.Composer;
        }

        void IEditableObject.BeginEdit()
        {

        }

        void IEditableObject.EndEdit()
        {
            if (!string.Equals(Name, _track.Name))
                _track.Name = Name;
            if (!string.Equals(Composer, _track.Composer))
                _track.Composer = Composer;
            if (TrackId != _track.TrackId)
                _track.TrackId = TrackId;
        }

        void IEditableObject.CancelEdit()
        {
            Load(this._track);
        }

        public virtual int TrackId { get; set; }
        public virtual string Name { get; set; }
        protected void OnNameChanged()
        {
            this.RaiseCanExecuteChanged(x => x.ResetName());
        }

        public virtual string Composer { get; set; }

        public void Save() { ((IEditableObject)this).EndEdit(); }
        public void Revert() { ((IEditableObject)this).CancelEdit(); }
    }
}
