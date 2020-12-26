using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace ClamRecipe
{
	public class ClamRecipe : Mod
	{

		public override void AddRecipes()
		{
			//Shrine Items
			Mod calamity = ModLoader.GetMod("CalamityMod");
			ModRecipe recipe = new ModRecipe(this);
			//recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("TheTransformer")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("SeaboundStaff")), 2);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("DuneHopper")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("AeroStone")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("BurntSienna")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("DriedSeafood")), 10);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("VictideBar")), 250);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("MandibleBow")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("AquamarineStaff")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("AbyssShocker")), 1);
			recipe.AddIngredient(ItemID.Ruby, 35);
			recipe.AddIngredient(ItemID.GoldBar, 115);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("LuxorsGift"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			//recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("TheTransformer")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("SeaboundStaff")), 2);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("DuneHopper")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("AeroStone")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("BurntSienna")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("DriedSeafood")), 10);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("VictideBar")), 250);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("MandibleBow")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("AquamarineStaff")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("AbyssShocker")), 1);
			recipe.AddIngredient(ItemID.Ruby, 35);
			recipe.AddIngredient(ItemID.PlatinumBar, 115);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("LuxorsGift"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("HellcasterFragment")), 200);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("AuricBar")), 88);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("Phaseslayer")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("Phantoplasm")), 300);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("CosmiliteBar")), 215);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("ArmoredShell")), 35);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("TwistingNether")), 15);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("Excelsus")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("UnholyCore")), 100);
			recipe.AddIngredient(ItemID.Muramasa, 3);
			recipe.AddIngredient(ItemID.Arkhalis, 1);
			recipe.AddIngredient(ItemID.RedPhasesaber, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("Murasama"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("ScuttlersJewel")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("Spadefish")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("AncientBoneDust")), 35);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("DemonicBoneAsh")), 25);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("MurkySludge")), 25);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("GlimmeringGemfish")), 15);
			recipe.AddIngredient(ItemID.Ruby, 25);
			recipe.AddIngredient(ItemID.LifeCrystal, 10);
			recipe.AddIngredient(ItemID.Obsidian, 1000);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("TrinketofChi"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("Cryophobia")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("FrostBarrier")), 2);
			recipe.AddIngredient(ItemID.Leather, 100);
			recipe.AddIngredient(ItemID.Diamond, 60);
			recipe.AddIngredient(ItemID.IceMachine, 3);
			recipe.AddIngredient(ItemID.SnowBlock, 2500);
			recipe.AddIngredient(ItemID.IceBlock, 2500);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("TundraLeash"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("TheTransformer")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("CruptixBar")), 100);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("Roxcalibur")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("MeldiateBar")), 900);
			//recipe.AddIngredient(ItemID.DrillContainmentUnit, 1);
			recipe.AddIngredient(ItemID.LaserDrill, 2);
			recipe.AddIngredient(ItemID.Obsidian, 5000);
			recipe.AddIngredient(ItemID.Diamond, 75);
			recipe.AddIngredient(ItemID.ShadowKey, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("OnyxExcavatorKey"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			//recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("TheTransformer")), 1);
			recipe.AddIngredient(ItemID.Javelin, 1000);
			recipe.AddIngredient(ItemID.GoldWatch, 1);
			recipe.AddIngredient(ItemID.MarbleBlock, 5000);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("GladiatorsLocket"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			//recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("TheTransformer")), 1);
			recipe.AddIngredient(ItemID.Diamond, 15);
			recipe.AddIngredient(ItemID.NightVisionHelmet, 1);
			recipe.AddIngredient(ItemID.GraniteBlock, 5000);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("UnstablePrism"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("DecapoditaSprout")), 5);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("FungalCarapace")), 2);
			recipe.AddIngredient(ItemID.GlowingMushroom, 500);
			recipe.AddIngredient(ItemID.MushroomGrassSeeds, 50);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("FungalSymbiote"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("Teratoma")), 5);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("BlightedGel")), 250);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("FetidEssence")), 50);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("CursedDagger")), 2);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("TrueShadowScale")), 200);
			recipe.AddIngredient(ItemID.RottenChunk, 100);
			recipe.AddIngredient(ItemID.WormTooth, 50);
			recipe.AddIngredient(ItemID.SoulofNight, 200);
			recipe.AddIngredient(ItemID.CursedFlame, 200);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("CorruptionEffigy"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("BloodyWormFood")), 5);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("BlightedGel")), 250);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("FetidEssence")), 50);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("IchorSpear")), 2);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("BloodSample")), 200);
			recipe.AddIngredient(ItemID.Vertebrae, 150);
			recipe.AddIngredient(ItemID.SoulofNight, 200);
			recipe.AddIngredient(ItemID.Ichor, 200);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("CrimsonEffigy"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("ShadowspecBar")), 50);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("BossRush"));
			recipe.AddRecipe();

			//Legendary
			//Melee

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("MajesticGuard")), 1);
			recipe.AddIngredient(ItemID.GolemBossBag, 20);
			recipe.AddIngredient(ItemID.BeetleHusk, 70);
			recipe.AddIngredient(ItemID.EyeoftheGolem, 1);
			recipe.AddIngredient(ItemID.GolemFist, 1);
			recipe.AddIngredient(ItemID.SunStone, 1);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 3);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("AegisBlade"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("AbyssBlade")), 1);
			recipe.AddIngredient(ItemID.FishronBossBag, 20);
			recipe.AddIngredient(ItemID.Flairon, 1);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 5);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("BrinyBaron"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("DevourerofGodsBag")), 20);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("Excelscus")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("CosmiliteBar")), 75);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 5);
			recipe.AddIngredient(ItemID.SolarEruption, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("CosmicDischarge"));
			recipe.AddRecipe();

			//Ranged

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("AquaticScourgeBag")), 25);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("Barinautical")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("CorrodedFossil")), 50);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("SeasSearing"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("LivingShard")), 40);
			recipe.AddIngredient(ItemID.PlanteraBossBag, 20);
			recipe.AddIngredient(ItemID.TempleKey, 5);
			recipe.AddIngredient(ItemID.ChlorophyteShotbow, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("BlossomFlux"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("ProvidenceBag")), 20);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("UnholyEssence")), 100);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("DivineGeode")), 75);
			recipe.AddIngredient(ItemID.Flamethrower, 1);
			recipe.AddIngredient(ItemID.EldMelter, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("PristineFury"));
			recipe.AddRecipe();

			//Magic

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("Zapper")), 1);
			recipe.AddIngredient(ItemID.DestroyerBossBag, 20);
			recipe.AddIngredient(ItemID.SoulofMight, 125);
			recipe.AddIngredient(ItemID.HallowedBar, 150);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("SHPC"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("InfernalRift")), 1);
			recipe.AddIngredient(ItemID.BossBagBetsy, 20);
			recipe.AddIngredient(ItemID.ApprenticeStaffT3, 1);
			recipe.AddIngredient(ItemID.MeteorStaff, 1);
			recipe.AddIngredient(ItemID.DefenderMedal, 350);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("Vesuvius"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("DarkSpark")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("HellcasterFragment")), 35);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("YharonBag")), 15);
			recipe.AddIngredient(ItemID.LastPrism, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("YharimsCrystal"));
			recipe.AddRecipe();

			//Summon

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("CryogenicStaff")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("CryoStone")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("FrigidBar")), 80);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("EssenceofEleum")), 50);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("CryogenBag")), 20);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("ColdDivinity"));
			recipe.AddRecipe();

			//Rogue

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("GacruxianMollusk")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("Stardust")), 100);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("AstralJelly")), 100);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("AstrumAureusBag")), 20);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("LeonidProgenitor"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("TheSyringe")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("InfectedArmorPlating")), 75);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("PlagueCellCluster")), 75);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("PlaguebringerGoliathBag")), 20);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("Malachite"));
			recipe.AddRecipe();

			//Accessory

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("LeviathanBag")), 20);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("LureofEnthrallment")), 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("TheCommunity"));
			recipe.AddRecipe();

			//Rare Item Variants
			//Accessories

			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.BeeCloak, 1);
			recipe.AddIngredient(ItemID.MimicBanner, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("TheBee"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("ShieldoftheOcean")), 2);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("DesertScourgeBag")), 12);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("DeepDiver"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("ArcanumoftheVoid")), 2);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("DarkPlasma")), 10);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("TheEvolution"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("GiantTortoiseShell")), 2);
			recipe.AddIngredient(ItemID.TortoiseBanner, 2);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("FabledTortoiseShell"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("AstralBulwark")), 2);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("AstrumDeusBag")), 12);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("HideofAstrumDeus"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("OrnateShield")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("CryogenBag")), 12);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("Regenator"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("BadgeofBravery")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("ProvidenceBag")), 12);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("SamuraiBadge"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("AmidiasSpark")), 2);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("CnidrionBanner")), 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("TheTransformer"));
			recipe.AddRecipe();

			//Melee

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("BloodyEdge")), 1);
			recipe.AddIngredient(ItemID.BloodZombieBanner, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("Carnage"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("AncientCrusher")), 2);
			recipe.AddIngredient(ItemID.DesertBasiliskBanner, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("EvilSmasher"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("GrandGuardian")), 1);
			recipe.AddIngredient(ItemID.MoonLordBossBag, 12);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("GrandDad"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("ArkoftheElements")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("BumblebirbBag")), 12);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("Swordsplosion"));
			recipe.AddRecipe();

			//Ranged

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("RaidersGlory")), 2);
			recipe.AddIngredient(ItemID.PirateCrossbowerBanner, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("Arbalest"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("Helstorm")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("DevilFishBanner")), 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("Hellborn"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("ConferenceCall")), 1);
			recipe.AddIngredient(ItemID.VortexRiflemanBanner, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("TrueConferenceCall"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("Shredder")), 1);
			recipe.AddIngredient(ItemID.MoonLordBossBag, 12);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("Infinity"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("ClockGatlignum")), 1);
			recipe.AddIngredient(ItemID.GolemBossBag, 12);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("LeadWizard"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("StarfleetMK2")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("DevourerofGodsBag")), 12);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("Norfleet"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("AMR")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("DevourerofGodsBag")), 12);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("Skullmasher"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("Aeries")), 1);
			recipe.AddIngredient(ItemID.DungeonSpiritBanner, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("PearlGod"));
			recipe.AddRecipe();

			//Magic

			recipe = new ModRecipe(this);
			//recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("ShadowspecBar")), 50);
			recipe.AddIngredient(ItemID.BookofSkulls, 2);
			recipe.AddIngredient(ItemID.SkeletronBossBag, 12);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("ClothiersWrath"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("MagnaCannon")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("AngryDogBanner")), 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("Cryophobia"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("LunicEye")), 1);
			recipe.AddIngredient(ItemID.RuneHat, 3);
			recipe.AddIngredient(ItemID.RuneRobe, 3);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("EyeofMagnus"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("ArchAmaryllis")), 1);
			recipe.AddIngredient(ItemID.AncientCultistTrophy, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("ThornBlossom"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("PlasmaRifle")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("CloudElementalBanner")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("DivineGeode")), 5);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("Thunderstorm"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("Climax")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("HellcasterFragment")), 35);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("YharonBag")), 10);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("VoidVortex"));
			recipe.AddRecipe();

			//Summon

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("Cosmilamp")), 2);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("TwistingNether")), 15);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("LanternoftheSoul"));
			recipe.AddRecipe();

			//Rogue

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("ScourgeoftheDesert")), 3);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("DesertScourgeBag")), 12);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("DuneHopper"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("RadiantStar")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("AstrumDeusBag")), 12);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("Quasar"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("Valediction")), 5);
			//recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("ReaperSharkBanner")), 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("TheReaper"));
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("IchorSpear")), 3);
			recipe.AddIngredient(ItemID.IchorStickerBanner, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("SpearofDestiny"));
			recipe.AddRecipe();

			//Biscuit

			recipe = new ModRecipe(this);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("ShadowspecBar")), 5);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("HadopelagicEcho")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("SoulEdge")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("TheReaper")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("Baguette")), 1);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("Lumenite")), 35);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("DepthCells")), 35);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("ReaperTooth")), 35);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("HalibutCannon"));
			recipe.AddRecipe();

			//Charger Test Item

			//recipe = new ModRecipe(this);
			//recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("DubiousPlating")), 15);
			//recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("MysteriousCircuitry")), 15);
			//recipe.AddTile(TileID.Anvils);
			//recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("DraedonsChargingStation"));
			//recipe.AddRecipe();

			//recipe = new ModRecipe(this);
			//recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("DubiousPlating")), 15);
			//recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("MysteriousCircuitry")), 15);
			//recipe.AddTile(TileID.Anvils);
			//recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("DraedonsFuelFactoryItem"));
			//recipe.AddRecipe();
		}
	}
}