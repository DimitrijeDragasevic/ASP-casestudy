namespace ASPcasestudy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Proba : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "DesktopComputersID", "dbo.DesktopComputers");
            DropForeignKey("dbo.Products", "ComputerComponentsID", "dbo.ComputerComponents");
            DropForeignKey("dbo.Products", "KeyboardsID", "dbo.Keyboards");
            DropForeignKey("dbo.Products", "LaptopsID", "dbo.Laptops");
            DropForeignKey("dbo.Products", "MouseID", "dbo.Mouse");
            DropForeignKey("dbo.Products", "TabletsID", "dbo.Tablets");
            DropIndex("dbo.Products", new[] { "DesktopComputersID" });
            DropIndex("dbo.Products", new[] { "LaptopsID" });
            DropIndex("dbo.Products", new[] { "TabletsID" });
            DropIndex("dbo.Products", new[] { "KeyboardsID" });
            DropIndex("dbo.Products", new[] { "MouseID" });
            DropIndex("dbo.Products", new[] { "ComputerComponentsID" });
            RenameColumn(table: "dbo.Products", name: "DesktopComputersID", newName: "DesktopComputers_DesktopComputersID");
            RenameColumn(table: "dbo.Products", name: "ComputerComponentsID", newName: "ComputerComponents_ComputerComponentsID");
            RenameColumn(table: "dbo.Products", name: "KeyboardsID", newName: "Keyboards_KeyboardsID");
            RenameColumn(table: "dbo.Products", name: "LaptopsID", newName: "Laptops_LaptopsID");
            RenameColumn(table: "dbo.Products", name: "MouseID", newName: "Mouse_MouseID");
            RenameColumn(table: "dbo.Products", name: "TabletsID", newName: "Tablets_TabletsID");
            AlterColumn("dbo.Products", "DesktopComputers_DesktopComputersID", c => c.Int());
            AlterColumn("dbo.Products", "Laptops_LaptopsID", c => c.Int());
            AlterColumn("dbo.Products", "Tablets_TabletsID", c => c.Int());
            AlterColumn("dbo.Products", "Keyboards_KeyboardsID", c => c.Int());
            AlterColumn("dbo.Products", "Mouse_MouseID", c => c.Int());
            AlterColumn("dbo.Products", "ComputerComponents_ComputerComponentsID", c => c.Int());
            CreateIndex("dbo.Products", "ComputerComponents_ComputerComponentsID");
            CreateIndex("dbo.Products", "DesktopComputers_DesktopComputersID");
            CreateIndex("dbo.Products", "Keyboards_KeyboardsID");
            CreateIndex("dbo.Products", "Laptops_LaptopsID");
            CreateIndex("dbo.Products", "Mouse_MouseID");
            CreateIndex("dbo.Products", "Tablets_TabletsID");
            AddForeignKey("dbo.Products", "DesktopComputers_DesktopComputersID", "dbo.DesktopComputers", "DesktopComputersID");
            AddForeignKey("dbo.Products", "ComputerComponents_ComputerComponentsID", "dbo.ComputerComponents", "ComputerComponentsID");
            AddForeignKey("dbo.Products", "Keyboards_KeyboardsID", "dbo.Keyboards", "KeyboardsID");
            AddForeignKey("dbo.Products", "Laptops_LaptopsID", "dbo.Laptops", "LaptopsID");
            AddForeignKey("dbo.Products", "Mouse_MouseID", "dbo.Mouse", "MouseID");
            AddForeignKey("dbo.Products", "Tablets_TabletsID", "dbo.Tablets", "TabletsID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Tablets_TabletsID", "dbo.Tablets");
            DropForeignKey("dbo.Products", "Mouse_MouseID", "dbo.Mouse");
            DropForeignKey("dbo.Products", "Laptops_LaptopsID", "dbo.Laptops");
            DropForeignKey("dbo.Products", "Keyboards_KeyboardsID", "dbo.Keyboards");
            DropForeignKey("dbo.Products", "ComputerComponents_ComputerComponentsID", "dbo.ComputerComponents");
            DropForeignKey("dbo.Products", "DesktopComputers_DesktopComputersID", "dbo.DesktopComputers");
            DropIndex("dbo.Products", new[] { "Tablets_TabletsID" });
            DropIndex("dbo.Products", new[] { "Mouse_MouseID" });
            DropIndex("dbo.Products", new[] { "Laptops_LaptopsID" });
            DropIndex("dbo.Products", new[] { "Keyboards_KeyboardsID" });
            DropIndex("dbo.Products", new[] { "DesktopComputers_DesktopComputersID" });
            DropIndex("dbo.Products", new[] { "ComputerComponents_ComputerComponentsID" });
            AlterColumn("dbo.Products", "ComputerComponents_ComputerComponentsID", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Mouse_MouseID", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Keyboards_KeyboardsID", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Tablets_TabletsID", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Laptops_LaptopsID", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "DesktopComputers_DesktopComputersID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Products", name: "Tablets_TabletsID", newName: "TabletsID");
            RenameColumn(table: "dbo.Products", name: "Mouse_MouseID", newName: "MouseID");
            RenameColumn(table: "dbo.Products", name: "Laptops_LaptopsID", newName: "LaptopsID");
            RenameColumn(table: "dbo.Products", name: "Keyboards_KeyboardsID", newName: "KeyboardsID");
            RenameColumn(table: "dbo.Products", name: "ComputerComponents_ComputerComponentsID", newName: "ComputerComponentsID");
            RenameColumn(table: "dbo.Products", name: "DesktopComputers_DesktopComputersID", newName: "DesktopComputersID");
            CreateIndex("dbo.Products", "ComputerComponentsID");
            CreateIndex("dbo.Products", "MouseID");
            CreateIndex("dbo.Products", "KeyboardsID");
            CreateIndex("dbo.Products", "TabletsID");
            CreateIndex("dbo.Products", "LaptopsID");
            CreateIndex("dbo.Products", "DesktopComputersID");
            AddForeignKey("dbo.Products", "TabletsID", "dbo.Tablets", "TabletsID", cascadeDelete: true);
            AddForeignKey("dbo.Products", "MouseID", "dbo.Mouse", "MouseID", cascadeDelete: true);
            AddForeignKey("dbo.Products", "LaptopsID", "dbo.Laptops", "LaptopsID", cascadeDelete: true);
            AddForeignKey("dbo.Products", "KeyboardsID", "dbo.Keyboards", "KeyboardsID", cascadeDelete: true);
            AddForeignKey("dbo.Products", "ComputerComponentsID", "dbo.ComputerComponents", "ComputerComponentsID", cascadeDelete: true);
            AddForeignKey("dbo.Products", "DesktopComputersID", "dbo.DesktopComputers", "DesktopComputersID", cascadeDelete: true);
        }
    }
}
