using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Webinar.ViewModels;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Webinar.Views
{
    public partial class TrackListView : DevExpress.XtraEditors.XtraUserControl
    {
        public TrackListView()
        {
            InitializeComponent();
            if (!DesignMode)
                InitBindings();
        }

        void InitBindings()
        {
            var mvvm = mvvmContext1.OfType<TrackListViewModel>();
            mvvm.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridView1, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedTrack,
                    args => args.Row as TrackInfo,
                    (gView, track) => gView.FocusedRowHandle = gView.FindRow(track));

            mvvm.WithEvent<RowClickEventArgs>(gridView1, "RowClick")
               .EventToCommand(
                   x => x.EditTrack(null), x => x.SelectedTrack,
                   args => (args.Clicks == 2) && (args.Button == MouseButtons.Left));
        }
    }
}
