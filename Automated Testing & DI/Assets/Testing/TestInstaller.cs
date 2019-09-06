﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using Mocks;

public class TestInstaller : Installer<TestInstaller>
{
    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<GameManager>()
            .AsSingle();

        Container.BindInterfacesAndSelfTo<InputManager>()
            .AsSingle();

        Container.Bind<IInventory>()
            .To<InventoryByID>()
            .AsTransient();

        Container.Bind<Item>()
            .To<MockItem>()
            .AsTransient();

        Container.Bind<IWeapon>()
            .To<MockWeapon>()
            .AsTransient();

        Container.Bind<IArmor>()
            .To<MockArmor>()
            .AsTransient();

        Container.Bind<ICharacter>()
            .To<MockCharacter>()
            .AsTransient();
    }
}
