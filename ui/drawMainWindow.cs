using System;
using Terminal.Gui;

namespace Phosphorus{

    public partial class mainWindow{

        public void init() {

            Application.Init();
            
            // set up menubar 
            var menu = new MenuBar (new MenuBarItem [] {
                new MenuBarItem ("_File", new MenuItem [] {
                    new MenuItem ("_Quit", "", () => { 
                        Application.RequestStop (); 
                    })
                }),
            });
            Application.Top.Add (menu);

            // set up main window
			var Win = new Window ($"CTRL-Q to Close - Phosphorus v0.0-curses") {
				X = 0,
				Y = 1,
				Width = Dim.Fill (),
				Height = Dim.Fill (),
			};
			Application.Top.Add (Win);

            
            // setupCheckboxes(Application.Top);
            Application.Run();
            Application.Shutdown();

        }
        public async void setupCheckboxes(View selectionView) {
            
            for (int i = 0; i < 5; i++){
                var checkbox = new CheckBox (0, i+1, "test");
                selectionView.Add(checkbox);
            }

        }
    }
}
