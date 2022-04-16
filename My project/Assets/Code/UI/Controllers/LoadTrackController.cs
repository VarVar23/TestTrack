public class LoadTrackController
{
    private MenuPanelView _menuPanelView;

    public LoadTrackController(PlayButtonView playButtonView, MenuPanelView menuPanelView)
    {
        _menuPanelView = menuPanelView;

        playButtonView.PlayButton.onClick.AddListener(LoadTrack);
    }

    private void LoadTrack() => _menuPanelView.gameObject.SetActive(false);

}
