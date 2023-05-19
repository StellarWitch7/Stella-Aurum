using Terraria;
using Terraria.ModLoader;

namespace StellaAurum.Content.Items.Armours.Vanity
{
    [AutoloadEquip(EquipType.Body)]
    internal class EllieShirt : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 14;
            Item.vanity = true;
        }
    }
}
