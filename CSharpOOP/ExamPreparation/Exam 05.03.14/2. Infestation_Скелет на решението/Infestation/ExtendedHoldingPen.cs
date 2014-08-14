using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class ExtendedHoldingPen : HoldingPen
    {
        protected override void ProcessSingleInteraction(Interaction interaction)
        {
            switch (interaction.InteractionType)
            {
                case InteractionType.Infest:
                    var targetUnit = this.GetUnit(interaction.TargetUnit);
                    targetUnit.AddSupplement(new InfestationSpores());

                    break;
                default:
                    base.ProcessSingleInteraction(interaction);
                    break;
            }

        }
        protected override void ExecuteInsertUnitCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "Tank":
                    var tank = new Tank(commandWords[2]);
                    this.InsertUnit(tank);
                    
                    break;
                case "Marine":
                    var marine = new Marine(commandWords[2]);
                    this.InsertUnit(marine);
                    break;
                case "Parasite":
                    var parasite = new Parasite(commandWords[2]);
                    this.InsertUnit(parasite);
                    break;
                case "Queen":
                    var queen = new Queen(commandWords[2]);
                    this.InsertUnit(queen);
                    break;
                default:
                    base.ExecuteInsertUnitCommand(commandWords);
                    break;
            }

        }
        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {

            ISupplement suplement;
            switch (commandWords[1])
            {
                case "PowerCatalyst":
                    suplement = new PowerCatalyst(); break;
                case "HealthCatalyst":
                    suplement = new HealthCatalyst(); break;
                case "AggressionCatalyst":
                    suplement = new AggressionCatalyst(); break;
                case "Weapon":
                    suplement = new Weapon(); break;
                case "WeaponarySkill":
                    suplement = new WeaponrySkill(); break;
                case "InfestationSpores":
                    suplement = new InfestationSpores(); break;

                default:
                    throw new InvalidOperationException("This supplement is not supported");
            }

            var targetUnit = this.GetUnit(commandWords[2]);
            targetUnit.AddSupplement(suplement);


        }
    }
}
