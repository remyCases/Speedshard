scr_atr_incr("XP", 90000)
scr_village_reputation_add_with_log("dialogue", 200, 1, global.osbrook_x, global.osbrook_y)
scr_village_reputation_add_with_log("dialogue", -200, 1, global.osbrook_x, global.osbrook_y)
scr_inventory_add_item(o_inv_backpack, id)
with(scr_inventory_add_item(o_inv_moneybag)) {
    ds_map_replace(data, "Stack", 2000)
}
repeat(2) {
    scr_inventory_add_item(o_inv_scroll_enchant)
}
scr_inventory_add_item(o_inv_map_aldor, id, -4, 1, -4, 1, 1)