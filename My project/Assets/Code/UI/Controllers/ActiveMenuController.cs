public class ActiveMenuController
{
    private MenuPanelView _menuPanelView;

    public ActiveMenuController(InputController inputController, MenuPanelView menuPanelView)
    {
        _menuPanelView = menuPanelView; 

        inputController.InputESC += ActiveMenu;
    }

    private void ActiveMenu() => _menuPanelView.gameObject.SetActive(true);
}
