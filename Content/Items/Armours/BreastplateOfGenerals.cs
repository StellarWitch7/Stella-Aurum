using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StellaAurum.Content.Items.Armours
{
    [AutoloadEquip(EquipType.Body)]
    internal class BreastplateOfGenerals : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.defense = 6;
        }

        public override void UpdateEquip(Player player)
        {
            // Give Buff Immunity
            player.buffImmune[BuffID.Frozen] = true;

            // Increase Health of Mana
            player.statLifeMax2 += 20;
            player.statManaMax2 += 20;

            // Increase Max Minions
            player.maxMinions += 2;

            // Increase Movement Speed
            player.moveSpeed += 0.07f;
        }
    }
}
