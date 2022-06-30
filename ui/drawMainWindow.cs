using System;
using Terminal.Gui;

using Phosphorus;

namespace Phosphorus{

    public partial class mainWindow{

        public void init(Phosphorus.Core core) {

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
			var Win = new Window ($"CTRL-Q to Close - Phosphorus v0.0b-curses") {
				X = 0,
				Y = 1,
				Width = Dim.Fill (),
				Height = Dim.Fill (),
			};
			Application.Top.Add (Win);

            setupCheckboxes(Win, core.modlist); // set up the checkboxes

            Application.Run();
            Application.Shutdown();

        }
        public async void setupCheckboxes(View selectionView, List<modProperties> mods) {
            
            int i = 0;
            foreach (modProperties mod in mods)
            {
                var checkbox = new CheckBox (0, i, mod.Name);
                selectionView.Add(checkbox);
                i++;
            }

        }
    }
}
