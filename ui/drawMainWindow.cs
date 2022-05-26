using System;
using Terminal.Gui;

namespace Phosphorus{

    public partial class mainWindow{

        public void init() {

            Application.Init();
            setupCheckboxes(Application.Top);
            var menu = new MenuBar (new MenuBarItem [] {
                new MenuBarItem ("_File", new MenuItem [] {
                    new MenuItem ("_Quit", "", () => { 
                        Application.RequestStop (); 
                    })
                }),
            });
            Application.Top.Add (menu);
            setupCheckboxes(Application.Top);
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
