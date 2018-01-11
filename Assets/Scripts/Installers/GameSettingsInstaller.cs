using LevelGenerators;
using UnityEngine;
using Zenject;

//[CreateAssetMenu(fileName = "GameSettingsInstaller", menuName = "Installers/GameSettingsInstaller")]
public class GameSettingsInstaller : ScriptableObjectInstaller<GameSettingsInstaller>
{
    public PlayerController.Settings Player;
    public BallController.Settings Ball;
    public BrickController.Settings Brick;
    public LevelManager.Settings LevelManager;

    public override void InstallBindings()
    {
        Container.BindInstance(Player);
        Container.BindInstance(Ball);
        Container.BindInstance(Brick);
        Container.BindInstance(LevelManager);
    }
}