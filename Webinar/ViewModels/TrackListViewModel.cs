using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace Webinar.ViewModels
{
    [POCOViewModel]
    public class TrackListViewModel
    {
        public virtual TrackList Tracks { get; set; }
        public virtual TrackInfo SelectedTrack {get; set;}
        protected TrackListViewModel()
        {
            Tracks = new TrackList();
        }

        public static TrackListViewModel Create()
        {
            return ViewModelSource.Create(() => new TrackListViewModel());
        }

        [ServiceProperty(SearchMode = ServiceSearchMode.PreferParents)]
        protected virtual IDocumentManagerService DocumentManagerService { get { return null; } }

        public void EditTrack(object trackObject)
        {
            var track = trackObject as TrackInfo;
            var document = DocumentManagerService.CreateDocument("TrackView", TrackViewModel.Create(track));
            document.Show();
            
        }
    }
}